using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Photon.Service.VPN.Models;

namespace Photon.Service.VPN.Handlers;

[Route("app/[controller]/[action]")]
public class Users : Controller
{
    public IActionResult State()
    {
        // var db = new DbContext();

        return Ok();
    }
}