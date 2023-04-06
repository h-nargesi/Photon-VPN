using Microsoft.AspNetCore.Mvc.Infrastructure;
using Photon.Service.VPN.Basical;

namespace Photon.Service.VPN.Pages
{
    public abstract class RegularView : VisualView
    {
        public readonly Menu RootMenu = new Menu(nameof(RootMenu));

        public override void OnGet()
        {
            base.OnGet();

            var menu = HttpContext.RequestServices.GetService<IActionDescriptorCollectionProvider>() ?? 
                       throw new Exception("IActionDescriptorCollectionProvider Service not found");

            foreach (var item in menu.ActionDescriptors.Items)
            {
                var page = item.RouteValues["page"] ?? string.Empty;
                if (page.Length > 0)
                {
                    var path = page.Split('/').Where(i => i.Length > 0).Select(i => i.FirstCharToUpper()).ToArray();
                    RootMenu.GetSubPages(page, path);
                }
            }
        }
    }
}
