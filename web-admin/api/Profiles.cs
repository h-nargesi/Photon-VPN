using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Photon.Service.VPN.Handlers.Model;
using Photon.Service.VPN.Models;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
public class Profiles : Controller
{
    [HttpPost]
    [Route("")]
    [Route("/srv/[controller]/[action]")]
    public async Task<IActionResult> List([FromRoute] int plan_id, [FromBody] ListQuery filter)
    {
        using var db = new RdContext();

        var query = from pr in db.Profiles.AsNoTracking()
                    join pl in db.Packages.AsNoTracking()
                            on pr.Id equals pl.ProfileId into @join
                    from pl in @join.DefaultIfEmpty()
                    where pl.PlanId == plan_id
                    select pr;

        var result = await filter.ApplyFilter(query, db);

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Options([FromBody] ListQuery filter)
    {
        using var db = new RdContext();

        var query = from pr in db.Profiles.AsNoTracking()
                    join pl in db.Packages.AsNoTracking()
                            on pr.Id equals pl.ProfileId into @join
                    from pl in @join.DefaultIfEmpty()
                    select new
                    {
                        id = pr.Id,
                        title = pr.Name,
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

        var quuey = db.Profiles.AsNoTracking()
                               .Where(c => c.Id == id);

        return Ok(await quuey.FirstOrDefaultAsync());
    }

    [HttpPost]
    public async Task<IActionResult> Modify([FromBody] Profile profile)
    {
        if (profile == null) return BadRequest();

        using var db = new RdContext();

        var original = await db.Profiles.AsNoTracking()
                                        .Where(c => c.Id == profile.Id)
                                        .FirstOrDefaultAsync();

        if (original == null)
        {
            profile.Created = profile.Modified = DateTime.Now;

            await db.Profiles.AddAsync(profile);
        }
        else
        {
            profile.Modified = DateTime.Now;

            db.Profiles.Attach(original);
            db.Entry(original).CurrentValues.SetValues(profile);
            db.Entry(original).Property(x => x.Created).IsModified = false;
        }

        await db.SaveChangesAsync();

        return Ok(Result.Success(data: original?.Id ?? profile.Id));
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