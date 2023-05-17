using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using Photon.Service.VPN.Handlers.Model;
using Photon.Service.VPN.Models;
using Photon.Service.VPN.App;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
public class UserLogs : Controller
{
    [HttpPost]
    [Route("{user_id:int}")]
    public async Task<IActionResult> List([FromRoute] int user_id, [FromBody] ListQuery filter)
    {
        using var db = new RdContext();

        var query = db.PermanentUserLogs.AsNoTracking()
                                        .Where(c => c.PermanentUserId == user_id)
                                        .OrderByDescending(c => c.Id);

        var result = await filter.AddIdentityColumn()
                                 .ApplyFilter(query)
                                 .ToDynamicListAsync();

        return Ok(result.SyncTimeList());
    }

    [HttpPost]
    [Route("{user_id:int}")]
    public IActionResult Count([FromRoute] int user_id, [FromBody] ListQuery filter)
    {
        using var db = new RdContext();

        var query = db.PermanentUserLogs.AsNoTracking()
                                        .Where(c => c.PermanentUserId == user_id);

        var filtered = filter.ApplyFilterCount(query);

        return Ok(filtered.Count());
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        using var db = new RdContext();

        var result = await db.PermanentUserLogs.AsNoTracking()
                             .Where(c => c.Id == id)
                             .FirstOrDefaultAsync();
        result.SyncTimeObject();

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Modify([FromBody] PermanentUserLog user)
    {
        if (user == null) return BadRequest();

        user.SyncTimeToUTC();

        using var db = new RdContext();

        var original = await db.PermanentUserLogs.AsNoTracking()
                                                 .Where(c => c.Id == user.Id)
                                                 .FirstOrDefaultAsync();

        if (original == null) await db.PermanentUserLogs.AddAsync(user);
        else
        {
            db.PermanentUserLogs.Attach(original);
            db.Entry(original).CurrentValues.SetValues(user);
        }

        await db.SaveChangesAsync();

        return Ok(Result.Success(data: original?.Id ?? user.Id));
    }

    [HttpPost]
    public async Task<IActionResult> Delete([FromBody] int id)
    {
        using var db = new RdContext();

        db.PermanentUserLogs.Remove(new PermanentUserLog { Id = id });
        await db.SaveChangesAsync();

        return Ok(Result.Success());
    }
}