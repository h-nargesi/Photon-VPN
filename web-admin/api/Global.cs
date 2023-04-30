using Microsoft.AspNetCore.Mvc;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
public class Global : Controller
{
    [HttpGet]
    public IActionResult Info()
    {
        var path = Request.Path;
        ViewData["RequestPath"] = path == "/" ? "/index" : path;

        var configuration = HttpContext.RequestServices.GetService<IConfiguration>() ??
                        throw new Exception("IConfiguration Service not found");

        configuration = configuration.GetSection("Organization");

        return Ok(configuration.GetSection("Organization"));
    }
}