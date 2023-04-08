using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using Photon.Service.VPN.App;
using System.Text.Json;
using static Photon.Service.VPN.App.TokenService;

namespace Photon.Service.VPN.Handlers;

public class BasicController : Controller
{
    private readonly int min_cache_seconds;
    private readonly string base_url;
    private readonly TokenService.TokenClient token_client;
    private readonly CacheService cache_service;
    private readonly IHttpClientFactory http_client_factory;

    public BasicController()
    {
        token_client = HttpContext.RequestServices.GetRequiredService<TokenService.TokenClient>();
        cache_service = HttpContext.RequestServices.GetRequiredService<CacheService>();
        http_client_factory = HttpContext.RequestServices.GetRequiredService<IHttpClientFactory>();

        var config = HttpContext.RequestServices.GetRequiredService<IConfiguration>();

        base_url = config["Cache:BaseUrl"] ?? throw new Exception("The base-url is not set.");

        _ = int.TryParse(config["Cache:MinCacheSeconds"], out min_cache_seconds);
        if (min_cache_seconds <= 0) min_cache_seconds = 86400;
    }

    protected Task<object?> GetData()
    {
        var url = GetUrl();
        var cache = cache_service.Get(url);

        if (cache != null && cache.Time.AddSeconds(min_cache_seconds) <= DateTime.UtcNow)
        {
            _ = MakeHttpRequest(HttpMethod.Get, url);
            return Task.FromResult(cache.Data);
        }
        else
        {
            return MakeHttpRequest(HttpMethod.Get, url);
        }
    }

    protected Task<object?> PostData(object data)
    {
        return MakeHttpRequest(HttpMethod.Post, GetUrl(), data);
    }

    private string GetUrl()
    {
        var url = HttpContext.Request.Path + "?" + HttpContext.Request.QueryString;
        if (url.EndsWith("?")) url = url[..^1];
        return url;
    }

    private async Task<object?> MakeHttpRequest(HttpMethod method, string url, object? data = null)
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

        if (data != null)
        {
            httpRequestMessage.Content = new StringContent(JsonSerializer.Serialize(data));
        }

        token_client.SignHttpRequest(httpRequestMessage, 0);

        var httpClient = http_client_factory.CreateClient();
        var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

        if (!httpResponseMessage.IsSuccessStatusCode)
        {
            throw new Exception(await httpResponseMessage.Content.ReadAsStringAsync());
        }

        using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();

        var result = await JsonSerializer.DeserializeAsync<object>(contentStream);

        if (method == HttpMethod.Get)
        {
            cache_service.UpdateData(url, result);
        }

        return result;
    }
}
