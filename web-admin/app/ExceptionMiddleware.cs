using Microsoft.AspNetCore.Diagnostics;
using Serilog;
using System.Net;

namespace Photon.Service.VPN.App;

public static class ExceptionMiddleware
{
    public static void ConfigureExceptionHandler(this IApplicationBuilder app)
    {
        app.UseWhen(context => context.Request.Path.StartsWithSegments("api") || context.Request.Path.StartsWithSegments("srv"),
                    appJson => appJson.UseExceptionHandler(appError => appError.Run(async context =>
                    {
                        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        context.Response.ContentType = "application/json";
                        var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                        if (contextFeature != null)
                        {
                            Log.Fatal(contextFeature.Error.StackTrace ?? string.Empty);
                            await context.Response.WriteAsync("Internal Server Error.");
                        }
                    })));

        app.UseExceptionHandler();
    }
}
