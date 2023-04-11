namespace Photon.Service.VPN.Handlers.Model;

public class ListQuery
{
    public int Start { get; set; }

    public int Limit { get; set; } = 1000;

    public string? Search { get; set; }

    public Filter[]? Filters { get; set; }

    public Dictionary<string, bool>? Ordering { get; set; }

    public class Filter
    {
        public string? Name { get; set; }

        public string? Value { get; set; }
    }

    public void ApplyFilter<T>(IQueryable<T> query)
    {
        ApplyWhere(query);
        ApplyOrdering(query);
        ApplyRecordLimits(query);
    }

    private void ApplyWhere<T>(IQueryable<T> query)
    {
        if (Filters == null) return;

        var type = typeof(T);
        foreach (var filter in Filters)
        {
            ApplyWhere(query, filter, type);
        }
    }

    private void ApplyWhere<T>(IQueryable<T> query, Filter filter, Type type)
    {
        var properties = type.GetProperties()
                             .Where(p => string.Compare(p.Name, filter.Name, true) == 0);

        foreach (var property in properties)
        {
            if (filter.Value == null)
            {
                query.Where(e => property.GetValue(e) == null);
            }
            else
            {
                query.Where(e => filter.Value.Equals(property.GetValue(e)));
            }
        }
    }

    private void ApplyOrdering<T>(IQueryable<T> query)
    {
        if (Ordering == null) return;

        var type = typeof(T);
        var properties = type.GetProperties()
                             .Where(p => Ordering.ContainsKey(p.Name));

        if (!properties.Any()) return;

        var first_prop = properties.First();

        if (Ordering[first_prop.Name.ToLower()])
            query.OrderBy(o => first_prop.GetValue(o, null));
        else
            query.OrderByDescending(o => first_prop.GetValue(o, null));

        foreach (var prop in properties.Skip(1))
        {
            if (Ordering[prop.Name.ToLower()])
                query.OrderBy(o => prop.GetValue(o, null));
            else
                query.OrderByDescending(o => prop.GetValue(o, null));
        }
    }

    private void ApplyRecordLimits<T>(IQueryable<T> query)
    {
        if (Start > 0)
        {
            query.Skip(Start);
        }

        if (Limit > 0)
        {
            query.Take(Limit);
        }
    }
}
