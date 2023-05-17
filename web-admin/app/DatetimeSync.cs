using System.Reflection;

namespace Photon.Service.VPN.App;

public static class DatetimeSync
{
    public static DateTime SyncTime(this DateTime dateTime, TimeZoneInfo? timeZone = null)
    {
        return TimeZoneInfo.ConvertTime(
            new DateTime(dateTime.Ticks, DateTimeKind.Utc),
            timeZone ?? TimeZoneInfo.Local);
    }

    public static T SyncTimeToUTC<T>(this T input)
    {
        var type = typeof(T);
        foreach (var p in type.GetProperties())
        {
            if (p.PropertyType != typeof(DateTime) &&
                p.PropertyType != typeof(DateTime?))
                continue;

            var datetime = (DateTime?)p.GetValue(input);
            p.SetValue(input, datetime?.ToUniversalTime());
        }

        return input;
    }

    public static T SyncTimeObject<T>(this T output, TimeZoneInfo? timeZone = null)
    {
        var type = typeof(T);
        foreach (var p in type.GetProperties())
        {
            if (p.PropertyType != typeof(DateTime) &&
                p.PropertyType != typeof(DateTime?))
                continue;

            var datetime = (DateTime?)p.GetValue(output);
            p.SetValue(output, datetime?.SyncTime(timeZone));
        }

        return output;
    }

    public static IEnumerable<T> SyncTimeList<T>(this IEnumerable<T> output, TimeZoneInfo? timeZone = null)
    {
        if (!output.Any()) return output;

        var type = typeof(T);


        foreach (var p in type.GetProperties())
        {
            if (p.PropertyType != typeof(DateTime) &&
                p.PropertyType != typeof(DateTime?))
                continue;

            foreach (var item in output)
            {
                if (item == null) continue;

                var datetime = (DateTime?)p.GetValue(item);
                p.SetValue(item, datetime?.SyncTime(timeZone));
            }
        }

        return output;
    }

    public static IEnumerable<dynamic> SyncTimeList(this IEnumerable<dynamic> output, TimeZoneInfo? timeZone = null)
    {
        if (!output.Any()) return output;

        var type = output.First().GetType();
        var properties = (PropertyInfo[])type.GetProperties();

        if (!properties.Any(x => x.PropertyType == typeof(DateTime) ||
                                x.PropertyType == typeof(DateTime?)))
            return output;

        properties = properties.Where(p => p.PropertyType.IsPrimitive)
                               .ToArray();

        var result = new List<RouteValueDictionary>();
        foreach (var item in output)
        {
            var record = new RouteValueDictionary(item);
            result.Add(record);

            foreach (var p in properties)
            {
                var value  = p.GetValue(item);

                if (value != null &&
                    (p.PropertyType == typeof(DateTime) ||
                    p.PropertyType == typeof(DateTime?)))
                {
                    value = ((DateTime)value).SyncTime(timeZone);
                }

                record[p.Name] = value;
            }
        }

        return result;
    }
}