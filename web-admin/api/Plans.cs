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
                        Active = pl != null ? pl.Active : false,
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


    [HttpGet]
    [Route("{id:int}")]
    [Route("/srv/[controller]/[action]/{id:int}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        using var db = new RdContext();

        var quuey = db.Plans.AsNoTracking()
                            .Where(c => c.Id == id);

        return Ok(await quuey.FirstOrDefaultAsync());
    }

    [HttpPost]
    public async Task<IActionResult> Modify([FromBody] Plan plan)
    {
        if (plan == null) return BadRequest();

        using var db = new RdContext();

        var original = await db.Plans.AsNoTracking()
                                     .Where(c => c.Id == plan.Id)
                                     .FirstOrDefaultAsync();

        if (original == null)
        {
            plan.Created = plan.Modified = DateTime.Now;

            await db.Plans.AddAsync(plan);
        }
        else
        {
            plan.Modified = DateTime.Now;

            db.Plans.Attach(original);
            db.Entry(original).CurrentValues.SetValues(plan);
            db.Entry(original).Property(x => x.Created).IsModified = false;
        }

        await db.SaveChangesAsync();

        return Ok(Result.Success(data: original?.Id ?? plan.Id));
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