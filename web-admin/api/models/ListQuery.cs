using System.Linq.Dynamic.Core;
using Photon.Service.VPN.App;

namespace Photon.Service.VPN.Handlers.Model;

public class ListQuery
{
    public int Start { get; set; }

    public int Limit { get; set; } = 1000;

    public string? Search { get; set; }

    public Dictionary<string, DbObject>? Filters { get; set; }

    public Dictionary<string, bool>? Ordering { get; set; }

    public string[]? Columns { get; set; }

    private HashSet<string>? ParimaryColumns = null;

    public ListQuery AddIdentityColumn()
    {
        ParimaryColumns ??= new HashSet<string>();

        ParimaryColumns.Add("id");
        return this;
    }

    public ListQuery ClearColumns()
    {
        ParimaryColumns?.Clear();
        ParimaryColumns = null;
        Columns = null;
        return this;
    }

    public IQueryable ApplyFilter(IQueryable query)
    {
        if (query == null) throw new ArgumentNullException(nameof(query));

        query = ApplyWhere(query);
        query = ApplyOrdering(query);
        query = ApplyRecordLimits(query);
        query = ApplySelection(query);
        
        // Serilog.Log.Information("List Query: " + query.ToQueryString());

        return query;
    }

    public IQueryable ApplyFilterCount(IQueryable query)
    {
        if (query == null) throw new ArgumentNullException(nameof(query));

        query = ApplyWhere(query);
        
        // Serilog.Log.Information("Count Query: " + query.ToQueryString());

        return query;
    }

    private IQueryable ApplyWhere(IQueryable query)
    {
        if (Filters == null || Filters.Count < 1) return query;

        var columns = new List<string>();
        var parameters = new List<object>();

        foreach (var filter in Filters)
        {
            if (filter.Value == null) continue;
            else if (filter.Value.Value == null)
            {
                columns.Add(filter.Key + " IS NULL");
            }
            else if (string.IsNullOrEmpty(filter.Value.Type))
            {
                columns.Add($"{FirstCharToUpper(filter.Key)}.Contains(@{parameters.Count})");
                parameters.Add(filter.Value.Value);
            }
            else
            {
                columns.Add(FirstCharToUpper(filter.Key) + " == @" + parameters.Count);
                parameters.Add(filter.Value.Convert());
            }
        }

        return query.Where(string.Join(" AND ", columns), parameters.ToArray());
    }

    private IQueryable ApplyOrdering(IQueryable query)
    {
        if (Ordering == null) return query;

        var columns = Ordering.Where(o => !string.IsNullOrWhiteSpace(o.Key))
                              .Select(o => FirstCharToUpper(o.Key) + (o.Value ? " asc" : " desc"));

        return query.OrderBy(string.Join(", ", columns));
    }

    private IQueryable ApplyRecordLimits(IQueryable query)
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

    private IQueryable ApplySelection(IQueryable qury)
    {
        if (Columns == null || Columns.Length < 1) return qury;
        else
        {
            ParimaryColumns ??= new HashSet<string>();

            var columns = ParimaryColumns.Union(Columns)
                                         .Where(c => !string.IsNullOrWhiteSpace(c))
                                         .Select(c => FirstCharToUpper(c))
                                         .ToHashSet();

            return qury.Select($"new {{ {string.Join(", ", columns)} }}");
        }
    }

    private static string? FirstCharToUpper(string? input)
    {
        if (string.IsNullOrWhiteSpace(input)) return input;
        else return string.Concat(input[0].ToString().ToUpper(), input.AsSpan(1));
    }

}
