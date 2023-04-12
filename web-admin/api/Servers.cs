using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Photon.Service.VPN.Models;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
public class Servers : Controller
{
    [HttpPost]
    public async Task<IActionResult> List()
    {
        using var db = new RdContext();

        var query = db.Nas.AsNoTracking();

        return Ok(await query.ToListAsync());
    }


    [HttpGet]
    [Route("{id:int}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        using var db = new RdContext();

        var quuey = db.Nas.AsNoTracking()
                          .Where(c => c.Id == id);

        return Ok(await quuey.FirstOrDefaultAsync());
    }

    [HttpPost]
    public async Task<IActionResult> Modify([FromBody] Na na)
    {
        if (na == null) return BadRequest();

        using var db = new RdContext();

        var original = await db.Nas.AsNoTracking()
                                   .Where(c => c.Id == na.Id)
                                   .FirstOrDefaultAsync();

        if (original == null) await db.Nas.AddAsync(na);
        else db.Entry(original).CurrentValues.SetValues(na);

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