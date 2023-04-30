using MySql.Data.MySqlClient;

namespace Photon.Service.VPN.App;

public class DbObject
{
    public string? Type { get; set; }

    public string? Value { get; set; }

    public MySqlDbType Convert(out object value)
    {
        MySqlDbType type;
        if (Type == null) type = MySqlDbType.String;
        else type = (MySqlDbType)System.Enum.Parse(typeof(MySqlDbType), Type);

        if (Value == null) value = DBNull.Value;
        else
            value = type switch
            {
                MySqlDbType.NewDecimal or MySqlDbType.Decimal => decimal.Parse(Value),
                MySqlDbType.Byte => sbyte.Parse(Value),
                MySqlDbType.UByte => byte.Parse(Value),
                MySqlDbType.Int16 => short.Parse(Value),
                MySqlDbType.Year or MySqlDbType.Int24 or MySqlDbType.Int32 => int.Parse(Value),
                MySqlDbType.Int64 => long.Parse(Value),
                MySqlDbType.Float => float.Parse(Value),
                MySqlDbType.Double => double.Parse(Value),
                MySqlDbType.Timestamp or MySqlDbType.Date or MySqlDbType.Time or MySqlDbType.Newdate or MySqlDbType.DateTime => DateTime.Parse(Value),
                MySqlDbType.JSON or MySqlDbType.TinyBlob or MySqlDbType.MediumBlob or MySqlDbType.LongBlob or MySqlDbType.Blob or MySqlDbType.VarChar or MySqlDbType.String or MySqlDbType.Geometry or MySqlDbType.Binary or MySqlDbType.VarBinary or MySqlDbType.TinyText or MySqlDbType.MediumText or MySqlDbType.LongText or MySqlDbType.Text or MySqlDbType.Guid or MySqlDbType.VarString => Value,
                MySqlDbType.Bit => bool.Parse(Value),
                MySqlDbType.UInt16 => ushort.Parse(Value),
                MySqlDbType.UInt24 => uint.Parse(Value),
                MySqlDbType.UInt32 => uint.Parse(Value),
                MySqlDbType.UInt64 => ulong.Parse(Value),
                _ => Value,
            };
        return type;
    }
}

