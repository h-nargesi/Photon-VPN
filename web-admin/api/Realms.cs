using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Photon.Service.VPN.Handlers.Model;
using Photon.Service.VPN.Models;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
public class Realms : Controller
{
    [HttpPost]
    public async Task<IActionResult> Options([FromBody] ListQuery filter)
    {
        using var db = new RdContext();

        var query = from rl in db.Realms.AsNoTracking()
                    select new
                    {
                        id = rl.Id,
                        title = rl.Name,
                    };

        var result = await filter.ApplyFilter(query, db);

        return Ok(result);
    }
}