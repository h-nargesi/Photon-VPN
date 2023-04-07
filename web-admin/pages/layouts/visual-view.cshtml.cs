using Microsoft.AspNetCore.Mvc.RazorPages;
using Serilog;

namespace Photon.Service.VPN.Pages
{
    public abstract class VisualView : PageModel
    {
        protected IConfiguration? configuration;

        public string Title => configuration?[nameof(Title)]?.ToString() ?? string.Empty;

        public string Logo => configuration?[nameof(Logo)]?.ToString() ?? string.Empty;

        public abstract string PageTitle { get; }

        public abstract string EditPage { get; }

        public virtual void OnGet()
        {
            var path = Request.Path;
            ViewData["RequestPath"] = path == "/" ? "/index" : path;

            Log.Information($"Request: ({ViewData["RequestPath"]}, {string.Join("&", Request.Query)})");

            configuration = HttpContext.RequestServices.GetService<IConfiguration>() ??
                            throw new Exception("IConfiguration Service not found");

            configuration = configuration.GetSection("Organization");
        }
    }
}
