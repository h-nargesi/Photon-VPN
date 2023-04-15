using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using Photon.Service.VPN.Models;
using System.Runtime.Serialization;

namespace Photon.Service.VPN.App;

public static class DatabaseExtension
{
    public static async Task<List<T>> ReadSql<T>(this RdContext db,
        string query, Dictionary<string, DbObject>? parameters)
    {
        var peroperties = typeof(T).GetProperties()
                                   .ToDictionary(k => k.Name.ToLower());

        using var connection = new MySqlConnection(db.Database.GetConnectionString());
        await connection.OpenAsync();

        using var command = connection.CreateCommand();
        command.CommandText = query;
        if (parameters != null)
            command.AddParameters(parameters);

        using var reader = await command.ExecuteReaderAsync();
        var result = new List<T>();

        while (await reader.ReadAsync())
        {
            var record = (T)FormatterServices.GetUninitializedObject(typeof(T));
            result.Add(record);

            for (var i = 0; i < reader.FieldCount; i++)
                peroperties[reader.GetName(i)].SetValue(record, reader.GetValue(i));
        }

        return result;
    }

    private static void AddParameters(this MySqlCommand command, Dictionary<string, DbObject> parameters)
    {
        foreach (var param in parameters)
            command.Parameters.Add(param.Key, param.Value.Convert(out var value)).Value = value;
    }
}
