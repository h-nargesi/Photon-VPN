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

builder.Services.AddRazorPages();
// builder.Services.AddScoped<TrendsCheckpoint>();
// builder.Services.AddSingleton<Analyzer>();
builder.Services.AddRouting(options => options.LowercaseUrls = true);

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapRazorPages();
});
app.Run();
