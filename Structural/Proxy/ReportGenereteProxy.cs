namespace Proxy;
using Microsoft.Extensions.Caching.Memory;

public class ReportGenereteProxy : IReportGenerete
{
    private readonly IReportGenerete _reportGenerete;
    private readonly IMemoryCache _cache;

    public ReportGenereteProxy(IReportGenerete reportGenerete)
    {
        _reportGenerete = reportGenerete;
        _cache = new MemoryCache(new MemoryCacheOptions());
    }

    public string Generete()
    {
        if (!_cache.TryGetValue("Report", out string? report))
        {
            report = _reportGenerete.Generete();
            _cache.Set("Report", report, new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(20)
            });
        }
        return report!;
    }
}
