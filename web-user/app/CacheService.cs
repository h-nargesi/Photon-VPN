namespace Photon.Service.VPN.App;

public class CacheService
{
    private readonly Dictionary<string, Cache> url_cache = new();

    public Cache? Get(string url)
    {
        url_cache.TryGetValue(url, out var cache);

        return cache;
    }

    public void UpdateTime(string url)
    {
        if (url_cache.TryGetValue(url, out var cache))
        {
            cache.Time = DateTime.UtcNow;
        }
    }

    public void UpdateData(string url, object? data)
    {
        url_cache[url] = new Cache
        {
            Time = DateTime.UtcNow,
            Data = data,
        };
    }

    public class Cache
    {
        public DateTime Time { get; set; }

        public object? Data { get; set; }
    }
}
