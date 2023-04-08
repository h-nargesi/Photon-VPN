using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Photon.Service.VPN.App;
using Photon.Service.VPN.Models;

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

    [HttpGet]
    public IActionResult Menu()
    {
        var menu = HttpContext.RequestServices.GetService<IActionDescriptorCollectionProvider>() ??
                   throw new Exception("IActionDescriptorCollectionProvider Service not found");

        var pages = menu.ActionDescriptors.Items
                        .Select(i => i.RouteValues["page"] ?? string.Empty)
                        .Where(i => i.Length > 0)
                        .Distinct();

        var RootMenu = new Menu("root");

        foreach (var page in pages)
        {
            var path = page.Split('/').Where(i => i.Length > 0).Select(i => i.FirstCharToUpper()).ToArray();
            RootMenu.AddChild(page, path);
        }

        return Ok(RootMenu);
    }
}