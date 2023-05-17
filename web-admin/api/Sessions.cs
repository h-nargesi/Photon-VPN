using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using Photon.Service.VPN.Handlers.Model;
using Photon.Service.VPN.Models;
using Photon.Service.VPN.App;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
public class Sessions : Controller
{
    [HttpPost]
    public async Task<IActionResult> List([FromQuery] bool? only_open, [FromBody] ListQuery filter)
    {
        using var db = new RdContext();

        var query = db.Radaccts.AsNoTracking();

        if (only_open ?? true)
        {
            query = query.Where(c => c.Acctstoptime == null);
        }

        var result = await filter.ApplyFilter(query)
                                 .ToDynamicListAsync();
        result.SyncTimeList();

        return Ok(result);
    }

    [HttpPost]
    public IActionResult Count([FromQuery] bool? only_open, [FromBody] ListQuery filter)
    {
        using var db = new RdContext();

        var query = db.Radaccts.AsNoTracking();

        if (only_open ?? true)
        {
            query = query.Where(c => c.Acctstoptime == null);
        }

        var filtered = filter.ApplyFilterCount(query);

        return Ok(filtered.Count());
    }

    [HttpPost]
    public IActionResult Kick([FromBody] string token, [FromBody] string username)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    [Route("{id:int}")]
    public IActionResult Close([FromRoute] int id)
    {
        throw new NotImplementedException();
    }

}