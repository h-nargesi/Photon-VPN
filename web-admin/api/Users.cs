using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using Photon.Service.VPN.Handlers.Model;
using Photon.Service.VPN.Models;
using Photon.Service.VPN.App;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
public class Users : Controller
{
    [HttpPost]
    public async Task<IActionResult> List([FromBody] ListQuery filter)
    {
        using var db = new RdContext();

        var query = db.PermanentUsers.AsNoTracking();

        var result = await filter.AddIdentityColumn()
                                 .ApplyFilter(query)
                                 .ToDynamicListAsync();

        return Ok(result.SyncTimeList());
    }

    [HttpPost]
    public IActionResult Count([FromBody] ListQuery filter)
    {
        using var db = new RdContext();

        var query = db.PermanentUsers.AsNoTracking();

        var filtered = filter.ApplyFilterCount(query);

        return Ok(filtered.Count());
    }

    [HttpPost]
    public async Task<IActionResult> ActiveCount()
    {
        using var db = new RdContext();

        var query = from user in db.PermanentUsers.AsNoTracking()
                    join profile in db.ProfilesWithSessionCounts()
                                 on user.ProfileId equals profile.Id
                    where user.ProfileId != null && user.Active &&
                          (user.FromDate == null || user.FromDate <= DateTime.UtcNow) &&
                          (user.ToDate == null || user.ToDate >= DateTime.UtcNow) &&
                          (user.PercTimeUsed == null || user.PercTimeUsed < 100) &&
                          (user.PercDataUsed == null || user.PercDataUsed < 100)
                    select profile.SimultaneousUses;

        var list = await query.ToListAsync();

        return Ok(list.Sum());
    }

    [HttpGet]
    public async Task<IActionResult> Options()
    {
        using var db = new RdContext();

        var result = await db.PermanentUsers.AsNoTracking()
                             .Select(ur => new OptionModel
                             {
                                 Id = ur.Id,
                                 Title = ur.Username +
                                     (string.IsNullOrEmpty(ur.Name) ? "" : " " + ur.Name) +
                                     (string.IsNullOrEmpty(ur.Surname) ? "" : " " + ur.Surname),
                             })
                             .OrderBy(ur => ur.Title)
                             .ToListAsync();

        result.SyncTimeList();

        return Ok(result);
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        using var db = new RdContext();

        var result = await db.PermanentUsers.AsNoTracking()
                             .Where(c => c.Id == id)
                             .FirstOrDefaultAsync();
        result.SyncTimeObject();

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Modify([FromBody] PermanentUser user)
    {
        if (user == null) return BadRequest();

        user.SyncTimeToUTC();

        using var db = new RdContext();

        var original = await db.PermanentUsers.AsNoTracking()
                                              .Where(c => c.Id == user.Id)
                                              .FirstOrDefaultAsync();

        if (original == null) await db.PermanentUsers.AddAsync(user);
        else
        {
            user.Modified = DateTime.UtcNow;

            db.PermanentUsers.Attach(original);
            db.Entry(original).CurrentValues.SetValues(user);
            db.Entry(original).Property(x => x.Created).IsModified = false;
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