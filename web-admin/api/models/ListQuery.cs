using Microsoft.EntityFrameworkCore;
using Photon.Service.VPN.App;
using Photon.Service.VPN.Models;
using System.Text;

namespace Photon.Service.VPN.Handlers.Model;

public class ListQuery
{
    public int Start { get; set; }

    public int Limit { get; set; } = 1000;

    public string? Search { get; set; }

    public Dictionary<string, DbObject>? Filters { get; set; }

    public Dictionary<string, bool>? Ordering { get; set; }

    public string[]? Columns { get; set; }

    public Task<List<T>> ApplyFilter<T>(IQueryable<T> query, RdContext db)
    {
        if (!HasFiltering())
        {
            return ApplyRecordLimits(query).ToListAsync();
        }

        var query_string = new StringBuilder(query.ToQueryString());

        ApplySelection(query_string);
        ApplyWhere(query_string);
        ApplyOrdering(query_string, typeof(T));
        ApplyRecordLimits(query_string);

        return db.ReadSql<T>(query_string.ToString(), Filters);
    }

    private bool HasFiltering()
    {
        return !string.IsNullOrEmpty(Search) || Filters?.Count > 0 || Ordering?.Count > 0 || Columns?.Length > 0;
    }

    private IQueryable<T> ApplyRecordLimits<T>(IQueryable<T> query)
    {
        if (Start > 0)
        {
            query = query.Skip(Start);
        }

        if (Limit > 0)
        {
            query = query.Take(Limit);
        }

        return query;
    }

    private void ApplySelection(StringBuilder query)
    {
        string selection;
        if (Columns == null || Columns.Length < 1) selection = "*";
        else selection = string.Join(",", Columns);

        query.Insert(0, " FROM (\n").Insert(0, selection).Insert(0, "SELECT ").Append("\n) qs\n");
    }

    private void ApplyWhere(StringBuilder query)
    {
        if (Filters == null || Filters.Count < 1) return;

        var columns = new List<string>();
        var parameters = new Dictionary<string, DbObject>();

        foreach (var filter in Filters)
        {
            if (filter.Value == null) continue;
            else if (filter.Value.Value == null)
            {
                columns.Add(filter.Key + " IS NULL");
            }
            else
            {
                parameters[filter.Key] = filter.Value;
                columns.Add(filter.Key + " = @" + filter.Key);
            }
        }

        Filters = parameters;

        query.Append("WHERE ").Append(string.Join(" AND ", columns)).Append('\n');
    }

    private void ApplyOrdering(StringBuilder query, Type type)
    {
        if (Ordering == null) return;

        var ordering = Ordering.ToDictionary(k => k.Key.ToLower(), v => v.Value);

        var properties = type.GetProperties()
                             .Where(p => ordering.ContainsKey(p.Name.ToLower()));

        if (!properties.Any()) return;

        var columns = new List<string>();

        foreach (var prop in properties)
        {
            if (ordering[prop.Name.ToLower()]) columns.Add(prop.Name);
            else columns.Add(prop.Name + " desc");
        }

        query.Append("ORDER BY ").Append(string.Join(", ", columns)).Append('\n');
    }

    private void ApplyRecordLimits(StringBuilder query)
    {
        if (Limit > 0)
        {
            query.Append(" LIMIT ").Append(Limit);
        }

        if (Start > 0)
        {
            query.Append(" OFFSET ").Append(Start);
        }
    }

}
