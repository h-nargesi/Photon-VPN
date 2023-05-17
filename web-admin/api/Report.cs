using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Photon.Service.VPN.App;
using Photon.Service.VPN.Models;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
public class Report : Controller
{
    [HttpGet]
    public async Task<IActionResult> Usage(
        [FromQuery] int? profile,
        [FromQuery] string? user,
        [FromQuery] string? realm,
        [FromQuery] string? nas,
        [FromQuery] DateInterval? period,
        [FromQuery] DateTime? start)
    {
        using var db = new RdContext();

        start = start?.ToUniversalTime();

        var query = db.Radaccts.AsNoTracking();

        if (profile.HasValue)
        {
            var users = db.PermanentUsers.AsNoTracking()
                                         .Where(u => u.ProfileId == profile.Value)
                                         .Select(u => u.Name);

            query = query.Where(a => users.Contains(a.Username));
        }

        if (!string.IsNullOrWhiteSpace(user))
        {
            query = query.Where(a => a.Username == user.Trim());
        }

        if (!string.IsNullOrWhiteSpace(realm))
        {
            query = query.Where(a => a.Realm == realm.Trim());
        }

        if (start.HasValue)
        {
            query = query.Where(a => a.Acctstarttime >= start.Value);
        }

        var result = await query.ToListAsync();
        result.SyncTimeList();

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> Income(
        [FromQuery] int? profile,
        [FromQuery] int? user,
        [FromQuery] int? realm,
        [FromQuery] DateInterval? period,
        [FromQuery] DateTime? start)
    {
        using var db = new RdContext();

        var query = db.Payments.AsNoTracking();

        start = start?.ToUniversalTime();

        if (profile.HasValue)
        {
            var users = db.PermanentUsers.AsNoTracking()
                                         .Where(u => u.ProfileId == profile.Value)
                                         .Select(u => u.Id);

            query = query.Where(a => users.Contains(a.PermanentUserId));
        }

        if (user.HasValue)
        {
            query = query.Where(a => a.Id == user.Value);
        }

        if (realm.HasValue)
        {
            var users = db.PermanentUsers.AsNoTracking()
                                         .Where(u => u.RealmId == realm.Value)
                                         .Select(u => u.Id);

            query = query.Where(a => users.Contains(a.PermanentUserId));
        }

        if (start.HasValue)
        {
            query = query.Where(a => a.DateTime >= start.Value);
        }

        var result = await query.ToListAsync();
        result.SyncTimeList();

        return Ok(result);
    }

}
