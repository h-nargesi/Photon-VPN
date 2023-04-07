using Microsoft.AspNetCore.Mvc.Infrastructure;
using Photon.Service.VPN.Basical;

namespace Photon.Service.VPN.Pages;

public abstract class RegularView : VisualView
{
    public readonly Menu RootMenu = new Menu(nameof(RootMenu));

    public override void OnGet()
    {
        base.OnGet();

        var menu = HttpContext.RequestServices.GetService<IActionDescriptorCollectionProvider>() ?? 
                   throw new Exception("IActionDescriptorCollectionProvider Service not found");

        var pages =  menu.ActionDescriptors.Items
                         .Select(i => i.RouteValues["page"] ?? string.Empty)
                         .Where(i => i.Length > 0)
                         .Distinct();

        foreach (var page in pages)
        {
            var path = page.Split('/').Where(i => i.Length > 0).Select(i => i.FirstCharToUpper()).ToArray();
            RootMenu.AddChild(page, path);
        }
    }
}
