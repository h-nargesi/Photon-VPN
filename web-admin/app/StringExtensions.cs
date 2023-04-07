namespace Photon.Service.VPN.Basical;

public static class StringExtensions
{
    public static string FirstCharToUpper(this string input) =>
        input switch
        {
            "" => string.Empty,
            _ => string.Concat(input[0].ToString().ToUpper(), input.AsSpan(1))
        };
}
