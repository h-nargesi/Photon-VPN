using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using Photon.Service.VPN.App;
using System.Text.Json;

namespace Photon.Service.VPN.Handlers;

public class BasicController : Controller
{
    private readonly int min_cache_seconds;
    private readonly string base_url;
    private readonly CacheService cache_service;
    private readonly IHttpClientFactory http_client_factory;

    public BasicController()
    {
        cache_service = HttpContext.RequestServices.GetRequiredService<CacheService>();
        http_client_factory = HttpContext.RequestServices.GetRequiredService<IHttpClientFactory>();

        var config = HttpContext.RequestServices.GetRequiredService<IConfiguration>();
        
        base_url = config["Cache:BaseUrl"];

        _ = int.TryParse(config["Cache:MinCacheSeconds"], out min_cache_seconds);
        if (min_cache_seconds <= 0) min_cache_seconds = 86400;
    }

    protected Task<object?> GetData(HttpMethod method, string url)
    {
        var cache = cache_service.Get(url);

        if (cache != null && cache.Time.AddSeconds(min_cache_seconds) <= DateTime.UtcNow)
        {
            _ = MakeHttpRequest(method, url);
            return Task.FromResult(cache.Data);
        }
        else
        {
            return MakeHttpRequest(method, url);
        }
    }

    private async Task<object?> MakeHttpRequest(HttpMethod method, string url)
    {
        if (!url.StartsWith("/"))
        {
            url = "/" + url;
        }

        var httpRequestMessage = new HttpRequestMessage(method, base_url + url)
        {
            Headers =
            {
                { HeaderNames.Accept, "application/json" },
                { HeaderNames.UserAgent, "HttpRequestsSample" }
            }
        };

        var httpClient = http_client_factory.CreateClient();
        var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
        
        if (!httpResponseMessage.IsSuccessStatusCode)
        {
            throw new Exception(await httpResponseMessage.Content.ReadAsStringAsync());
        }

        using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();

        var data = await JsonSerializer.DeserializeAsync<object>(contentStream);

        cache_service.UpdateData(url, data);

        return data;
    }
}
