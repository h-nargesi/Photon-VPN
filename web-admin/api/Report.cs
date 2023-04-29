using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Photon.Service.VPN.Models;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
public class Report : Controller
{
    [HttpGet]
    public async Task<IActionResult> Usage(
        [FromQuery] int? user_id, 
        [FromQuery] int? profile_id, 
        [FromQuery] DateInterval? period, 
        [FromQuery] DateTime? start)
    {
        using var db = new RdContext();

        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> Income(
        [FromQuery] int? user_id,
        [FromQuery] int? profile_id,
        [FromQuery] DateInterval? period,
        [FromQuery] DateTime? start)
    {
        using var db = new RdContext();

        return Ok();
    }
}
