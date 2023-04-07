using Microsoft.AspNetCore.Mvc.Infrastructure;
using Newtonsoft.Json;

namespace Photon.Service.VPN.Pages;

public class RoutesPage : RegularView
{
    public const string TITLE = "Routes";
    public const string ICON = "fas fa-page";
    public const float ORDER = 100;

    public override string PageTitle => TITLE;
    public override string EditPage => string.Empty;
    public List<string[]> PageList { get; } = new();

    public override void OnGet()
    {
        base.OnGet();

        var menu = HttpContext.RequestServices.GetService<IActionDescriptorCollectionProvider>() ??
                   throw new Exception("IActionDescriptorCollectionProvider Service not found");

        var pages = menu.ActionDescriptors.Items
                        .Select(i => new string[] {
                            i.AttributeRouteInfo?.Name ?? string.Empty,
                            i.AttributeRouteInfo?.Template ?? string.Empty,
                            i.RouteValues["page"] ?? string.Empty,
                            i.RouteValues["Action"] ?? string.Empty,
                            i.RouteValues["Controller"] ?? string.Empty,
                            JsonConvert.SerializeObject(i.ActionConstraints ?? new object()),
                        })
                        .ToArray();

        PageList.AddRange(pages);
    }
}
