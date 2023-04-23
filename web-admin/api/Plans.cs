using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
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

        var query = from pr in db.Profiles.AsNoTracking()
                    join pl in db.Plans.AsNoTracking()
                            on pr.Id equals pl.ProfileId into @join
                    from pl in @join.DefaultIfEmpty()
                    select new
                    {
                        pr.Id,
                        pr.Name,
                        Active = pl != null ? pl.Active : false,
                        //pr.CloudId,
                        Price = pl != null ? pl.Price : (decimal?)null,
                        ImageFile = pl != null ? pl.ImageFile : null,
                        Color = pl != null ? pl.Color : 0,
                        Description = pl != null ? pl.Description : null,
                        RegisterTime = pr.Created,
                        ModificationTime = pl != null && pl.ModificationTime > pr.Modified ? pl.ModificationTime : pr.Modified,
                    };

        var result = await filter.ApplyFilter(query, db);

        return Ok(result);
    }


    [HttpGet]
    [Route("{id:int}")]
    [Route("/srv/[controller]/[action]/{id:int}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        using var db = new RdContext();

        var quuey = from pr in db.Profiles.AsNoTracking()
                    join pl in db.Plans.AsNoTracking()
                            on pr.Id equals pl.ProfileId into @join
                    from pl in @join.DefaultIfEmpty()
                    where pr.Id == id
                    select new PlanProfile
                    {
                        Id = pr.Id,
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

            if (original == null)
            {
                plan_profile.Profile.Created =
                plan_profile.Profile.Modified = DateTime.Now;

                await db.Profiles.AddAsync(plan_profile.Profile);
            }
            else
            {
                plan_profile.Profile.Modified = DateTime.Now;

                db.Profiles.Attach(original);
                db.Entry(original).CurrentValues.SetValues(plan_profile.Profile);
                db.Entry(original).Property(x => x.Created).IsModified = false;
            }

            await db.SaveChangesAsync();

            if (plan_profile.Plan != null)
                plan_profile.Plan.ProfileId = plan_profile.Profile.Id;
        }

        if (plan_profile.Plan != null)
        {
            var original = await db.Plans.AsNoTracking()
                                         .Where(c => c.ProfileId == plan_profile.Plan.ProfileId)
                                         .FirstOrDefaultAsync();

            if (original == null)
            {
                plan_profile.Plan.RegisterTime =
                plan_profile.Plan.ModificationTime = DateTime.Now;

                await db.Plans.AddAsync(plan_profile.Plan);
            }
            else
            {
                plan_profile.Plan.ModificationTime = DateTime.Now;

                db.Plans.Attach(original);
                db.Entry(original).CurrentValues.SetValues(plan_profile.Plan);
                db.Entry(original).Property(x => x.RegisterTime).IsModified = false;
            }

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