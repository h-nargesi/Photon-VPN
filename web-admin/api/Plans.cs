using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using Photon.Service.VPN.Handlers.Model;
using Photon.Service.VPN.Models;

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
                        Active = pl != null && pl.Active,
                        Price = pl != null ? pl.Price : (decimal?)null,
                        ImageFile = pl != null ? pl.ImageFile : null,
                        Color = pl != null ? pl.Color : 0,
                        Speed = string.Empty,
                        Traffic = string.Empty,
                        pl.Created,
                        pl.Modified,
                    };

        var filtered = filter.ApplyFilter(query);

        return Ok(await filtered.ToDynamicListAsync());
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
                                              .ToList();

            var rad_replies = db.Radgroupreplies.AsNoTracking()
                                                .Where(r => r.Groupname == ProfileViews.SimpleAdd + sample_profile_id.Value)
                                                .ToList();

            foreach (var rad_check in rad_checks)
            {
                result.Checks.Add(rad_check.Attribute, rad_check);
            }

            foreach (var rad_reply in rad_replies)
            {
                result.Replies.Add(rad_reply.Attribute, rad_reply);
            }
        }

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Modify([FromBody] Plan plan)
    {
        if (plan == null) return BadRequest();

        plan = await new PlanBusiness().Save(plan);

        return Ok(Result.Success(data: plan.Id));
    }

    [HttpPost]
    public async Task<IActionResult> Profiles([FromRoute] int plan_id, [FromBody] int[] profiles)
    {
        if (profiles == null) return BadRequest();

        using var db = new RdContext();

        var current_packages = await db.Packages.AsNoTracking()
                                                .Where(p => p.PlanId == plan_id)
                                                .ToArrayAsync();

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
        using var db = new RdContext();

        db.Plans.Remove(new Plan { Id = id });
        await db.SaveChangesAsync();

        return Ok(Result.Success());
    }
}