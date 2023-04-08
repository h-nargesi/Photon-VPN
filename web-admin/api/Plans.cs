using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Photon.Service.VPN.Handlers.Model;
using Photon.Service.VPN.Models;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
public class Plans : Controller
{
    [HttpGet]
    [Route("")]
    [Route("/srv/[controller]/[action]")]
    public async Task<IActionResult> List()
    {
        using var db = new RdContext();

        var query = db.Plans.AsNoTracking();

        return Ok(await query.ToListAsync());
    }


    [HttpGet]
    [Route("{id}")]
    [Route("/srv/[controller]/[action]/{id}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        using var db = new RdContext();

        var quuey = from pr in db.Profiles.AsNoTracking()
                    join pl in db.Plans.AsNoTracking()
                            on pr.Id equals pl.ProfileId
                    where pr.Id == id
                    select new
                    {
                        Profile = pr,
                        Plan = pl,
                    };

        return Ok(await quuey.FirstOrDefaultAsync());
    }

    [HttpPost]
    public async Task<IActionResult> Modify([FromBody] PlanProfile plan_profile)
    {
        if (plan_profile == null) return BadRequest();

        using var db = new RdContext();

        if (plan_profile.Profile != null)
        {
            var original = await db.Profiles.AsNoTracking()
                                            .Where(c => c.Id == plan_profile.Profile.Id)
                                            .FirstOrDefaultAsync();

            if (original == null) await db.Profiles.AddAsync(plan_profile.Profile);
            else db.Entry(original).CurrentValues.SetValues(plan_profile.Profile);

            await db.SaveChangesAsync();
        }

        if (plan_profile.Plan != null)
        {
            var original = await db.Plans.AsNoTracking()
                                         .Where(c => c.ProfileId == plan_profile.Plan.ProfileId)
                                         .FirstOrDefaultAsync();

            if (original == null) await db.Plans.AddAsync(plan_profile.Plan);
            else db.Entry(original).CurrentValues.SetValues(plan_profile.Plan);

            await db.SaveChangesAsync();
        }

        return Ok(Result.Success(data: plan_profile.Profile?.Id ?? plan_profile.Plan?.ProfileId));
    }

    [HttpPost]
    public async Task<IActionResult> Delete([FromBody] int id)
    {
        using var db = new RdContext();

        db.Profiles.Remove(new Profile { Id = id });
        await db.SaveChangesAsync();

        return Ok(Result.Success());
    }
}