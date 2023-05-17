using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Photon.Service.VPN.App;
using Photon.Service.VPN.Models;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
public class Servers : Controller
{
    [HttpPost]
    public async Task<IActionResult> List()
    {
        using var db = new RdContext();

        var result = await db.Nas.AsNoTracking()
                                 .ToListAsync();
        result.SyncTimeList();

        return Ok(result);
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        using var db = new RdContext();

        var result = await db.Nas.AsNoTracking()
                                 .Where(c => c.Id == id)
                                 .FirstOrDefaultAsync();
        result.SyncTimeObject();

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Modify([FromBody] Na na)
    {
        if (na == null) return BadRequest();

        na.SyncTimeToUTC();

        using var db = new RdContext();

        var original = await db.Nas.AsNoTracking()
                                   .Where(c => c.Id == na.Id)
                                   .FirstOrDefaultAsync();

        if (original == null)
        {
            na.Timezone = "262";
            na.Created = na.Modified = DateTime.UtcNow;
            na.CloudId = 23;

            await db.Nas.AddAsync(na);
        }
        else
        {
            na.Modified = DateTime.UtcNow;
            na.CloudId = 23;

            db.Nas.Attach(original);
            db.Entry(original).CurrentValues.SetValues(na);
            db.Entry(original).Property(x => x.Created).IsModified = false;
        }

        await db.SaveChangesAsync();

        return Ok(Result.Success(data: original?.Id ?? na.Id));
    }

    [HttpPost]
    public async Task<IActionResult> Delete([FromBody] int id)
    {
        using var db = new RdContext();

        db.Nas.Remove(new Na { Id = id });
        await db.SaveChangesAsync();

        return Ok(Result.Success());
    }
}