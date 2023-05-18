using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using Photon.Service.VPN.Handlers.Model;
using Photon.Service.VPN.Models;
using Photon.Service.VPN.App;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
public class Realms : Controller
{
    [HttpGet]
    public async Task<IActionResult> Options()
    {
        using var db = new RdContext();

        var result = await db.Realms.AsNoTracking()
                             .Select(rl => new OptionModel
                             {
                                 Id = rl.Name,
                                 Title = rl.Name,
                             })
                             .OrderBy(ur => ur.Title)
                             .ToListAsync();

        result.SyncTimeList();

        return Ok(result);
    }
}