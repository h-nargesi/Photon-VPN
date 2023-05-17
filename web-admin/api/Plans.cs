using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using Photon.Service.VPN.Handlers.Model;
using Photon.Service.VPN.Models;
using Photon.Service.VPN.App;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
public class Plans : Controller
{
    [HttpPost]
    [Route("")]
    [Route("/srv/[controller]/[action]")]
    public async Task<IActionResult> List([FromBody] ListQuery filter)
    {
        using var db = new RdContext();

        var query = from pl in db.Plans.AsNoTracking()
                    select new
                    {
                        pl.Id,
                        pl.Title,
                        pl.Active,
                        pl.Price,
                        pl.ImageFile,
                        pl.Color,
                        Speed = string.Empty,
                        Traffic = string.Empty,
                        pl.Created,
                        pl.Modified,
                    };

        var result = await filter.AddIdentityColumn()
                                 .ApplyFilter(query)
                                 .ToDynamicListAsync();

        return Ok(result.SyncTimeList());
    }

    [HttpPost]
    [Route("")]
    [Route("/srv/[controller]/[action]")]
    public IActionResult Count([FromBody] ListQuery filter)
    {
        using var db = new RdContext();

        var query = db.Plans.AsNoTracking();

        var filtered = filter.ApplyFilterCount(query);

        return Ok(filtered.Count());
    }

    [HttpGet]
    [Route("{id:int}")]
    [Route("/srv/[controller]/[action]/{id:int}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        using var db = new RdContext();

        var result = await db.Plans.AsNoTracking()
                             .Where(c => c.Id == id)
                             .FirstOrDefaultAsync();

        if (result == null) return Ok();

        result.SyncTimeObject();

        result.SessionCounts = await db.ProfilesWithSessionCounts()
                                       .Where(p => p.PlanId == id)
                                       .Select(p => p.SimultaneousUses)
                                       .ToListAsync();

        var sample_profile_id = result.Packages.Where(pk => pk.PlanId == id)
                                               .Select(pk => (int?)pk.ProfileId)
                                               .FirstOrDefault();

        if (sample_profile_id.HasValue)
        {
            var rad_checks = db.Radgroupchecks.AsNoTracking()
                               .Where(r => r.Groupname == ProfileViews.SimpleAdd + sample_profile_id.Value)
                               .ToListAsync();

            var rad_replies = db.Radgroupreplies.AsNoTracking()
                                .Where(r => r.Groupname == ProfileViews.SimpleAdd + sample_profile_id.Value)
                                .ToListAsync();

            foreach (var rad_check in await rad_checks)
            {
                result.Checks.Add(rad_check.Attribute, rad_check);
            }

            result.Checks.SyncTimeList();

            foreach (var rad_reply in await rad_replies)
            {
                result.Replies.Add(rad_reply.Attribute, rad_reply);
            }

            result.Replies.SyncTimeList();
        }

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Modify([FromBody] Plan plan)
    {
        if (plan == null) return BadRequest();

        plan.SyncTimeToUTC();

        plan = await PlanBusiness.Save(plan);

        return Ok(Result.Success(data: plan.Id));
    }

    [HttpPost]
    public async Task<IActionResult> Profiles([FromRoute] int plan_id, [FromBody] int[] profiles)
    {
        if (profiles == null) return BadRequest();

        using var db = new RdContext();

        var current_packages = db.Packages.AsNoTracking()
                                          .Where(p => p.PlanId == plan_id);

        db.Packages.RemoveRange(current_packages);
        await db.SaveChangesAsync();

        foreach (var profiles_id in profiles)
        {
            await db.Packages.AddAsync(new Package
            {
                PlanId = plan_id,
                ProfileId = profiles_id,
            });
        }

        await db.SaveChangesAsync();

        return Ok(Result.Success());
    }

    [HttpPost]
    public async Task<IActionResult> Delete([FromBody] int id)
    {
        await PlanBusiness.Delete(id);

        return Ok(Result.Success());
    }
}