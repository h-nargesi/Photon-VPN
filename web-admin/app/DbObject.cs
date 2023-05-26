using MySqlConnector;

namespace Photon.Service.VPN.App;

public class DbObject
{
    public string? Type { get; set; }

    public string? Value { get; set; }

    public void Set(string column, List<string> columns, List<object> parameters)
    {
        var type = ConvertType();

        if (string.IsNullOrEmpty(Value))
        {
            if (type == MySqlDbType.String)
                columns.Add($"({column} IS NULL OR {column} == string.Empty)");
            else columns.Add($"{column} IS NULL");
        }
        else
        {
            var value_str = Value.Trim();
            var value_opt = ConvertOperator(ref value_str, parameters.Count);
            var value = ConvertValue(value_str, type);
            
            columns.Add(column + value_opt);
            parameters.Add(value);
        }
    }

    private MySqlDbType? ConvertType()
    {
        if (Type == null) return null;
        else return (MySqlDbType)System.Enum.Parse(typeof(MySqlDbType), Type, true);
    }

    private static string ConvertOperator(ref string value, int index)
    {
        if (value.StartsWith("="))
        {
            value = value.Substring(1);
            return $" == @{index}";
        }
        else if (value.StartsWith(">"))
        {
            value = value.Substring(1);
            return $" > @{index}";
        }
        else if (value.StartsWith(">="))
        {
            value = value.Substring(2);
            return $" >= @{index}";
        }
        else if (value.StartsWith("<"))
        {
            value = value.Substring(1);
            return $" < @{index}";
        }
        else if (value.StartsWith("<="))
        {
            value = value.Substring(2);
            return $" <= @{index}";
        }
        else
        {
            return $".Contains(@{index})";
        }
    }

    private static object ConvertValue(string value, MySqlDbType? type)
    {
        if (type == null) return value;
        else return type switch
        {
            MySqlDbType.NewDecimal or MySqlDbType.Decimal => decimal.Parse(value),
            MySqlDbType.Byte => sbyte.Parse(value),
            MySqlDbType.UByte => byte.Parse(value),
            MySqlDbType.Int16 => short.Parse(value),
            MySqlDbType.Year or MySqlDbType.Int24 or MySqlDbType.Int32 => int.Parse(value),
            MySqlDbType.Int64 => long.Parse(value),
            MySqlDbType.Float => float.Parse(value),
            MySqlDbType.Double => double.Parse(value),
            MySqlDbType.Timestamp or MySqlDbType.Date or MySqlDbType.Time or
                MySqlDbType.Newdate or MySqlDbType.DateTime => DateTime.Parse(value),
            MySqlDbType.JSON or MySqlDbType.TinyBlob or MySqlDbType.MediumBlob or MySqlDbType.LongBlob or MySqlDbType.Blob or
                MySqlDbType.VarChar or MySqlDbType.String or MySqlDbType.Geometry or MySqlDbType.Binary or MySqlDbType.VarBinary or
                MySqlDbType.TinyText or MySqlDbType.MediumText or MySqlDbType.LongText or MySqlDbType.Text or MySqlDbType.Guid or
                MySqlDbType.VarString => value,
            MySqlDbType.Bit => bool.Parse(value),
            MySqlDbType.UInt16 => ushort.Parse(value),
            MySqlDbType.UInt24 => uint.Parse(value),
            MySqlDbType.UInt32 => uint.Parse(value),
            MySqlDbType.UInt64 => ulong.Parse(value),
            _ => value,
        };
    }

}

