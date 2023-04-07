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

        var model = await db.PermanentUsers.AsNoTracking().ToListAsync();
        
        return Ok(model);
    }
}