using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Photon.Service.VPN.Handlers.Model;
using Photon.Service.VPN.Models;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
public class Users : Controller
{
    [HttpPost]
    public async Task<IActionResult> List([FromBody] ListQuery filter)
    {
        using var db = new RdContext();

        var query = db.PermanentUsers.AsNoTracking();

        return Ok(await filter.ApplyFilter(query, db));
    }

    [HttpPost]
    public async Task<IActionResult> Options([FromBody] ListQuery filter)
    {
        using var db = new RdContext();

        var query = from ur in db.PermanentUsers.AsNoTracking()
                    select new
                    {
                        Id = ur.Id,
                        Title = ur.Username +
                            (string.IsNullOrEmpty(ur.Name) ? "" : " " + ur.Name) +
                            (string.IsNullOrEmpty(ur.Surname) ? "" : " " + ur.Surname),
                    };

        return Ok(await filter.ApplyFilter(query, db));
    }

    [HttpGet]
    [Route("{id:int}")]
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
        else
        {
            db.PermanentUsers.Attach(original);
            db.Entry(original).CurrentValues.SetValues(user);
        }

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