using Microsoft.AspNetCore.Mvc;
using Photon.Service.VPN.App;
using Serilog;
using Serilog.Events;

var builder = WebApplication.CreateBuilder(args);

var file_event_level = builder.Environment.IsDevelopment() ? LogEventLevel.Debug : LogEventLevel.Information;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console(Serilog.Events.LogEventLevel.Debug)
    .WriteTo.File(builder.Configuration["Logging:FilePath"].ToString(), file_event_level, rollingInterval: RollingInterval.Day)
    .CreateLogger();

Log.Information("Starting up ...");

builder.Services.AddControllers(options =>
{
    options.AllowEmptyInputInBodyModelBinding = true;
});
builder.Services.AddSingleton<TokenService.TokenServer>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();
app.Run();
