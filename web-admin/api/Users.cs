using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Photon.Service.VPN.Models;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
public class Users : Controller
{
    [HttpGet]
    public async Task<IActionResult> List()
    {
        using var db = new RdContext();

        var query = db.PermanentUsers.AsNoTracking();

        return Ok(await query.ToListAsync());
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        using var db = new RdContext();

        var quuey = db.PermanentUsers.AsNoTracking()
                                     .Where(c => c.Id == id);

        return Ok(await quuey.FirstOrDefaultAsync());
    }

    [HttpPost]
    public async Task<IActionResult> Modify([FromBody] PermanentUser user)
    {
        if (user == null) return BadRequest();

        using var db = new RdContext();

        var original = await db.PermanentUsers.AsNoTracking()
                                              .Where(c => c.Id == user.Id)
                                              .FirstOrDefaultAsync();

        if (original == null) await db.PermanentUsers.AddAsync(user);
        else db.Entry(original).CurrentValues.SetValues(user);

        await db.SaveChangesAsync();

        return Ok(Result.Success(data: original?.Id ?? user.Id));
    }

    [HttpPost]
    public async Task<IActionResult> Delete([FromBody] int id)
    {
        using var db = new RdContext();

        db.PermanentUsers.Remove(new PermanentUser { Id = id });
        await db.SaveChangesAsync();

        return Ok(Result.Success());
    }
}