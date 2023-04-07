namespace Photon.Service.VPN.Handlers;

public class Result
{
    private Result() { }

    public ResultStatus Status { get; set; }

    public string? Message { get; set; }

    public object? Data { get; set; }

    public static Result Success(string? message = null, object? data = null)
    {
        return new Result()
        {
            Status = ResultStatus.Success,
            Message = message,
            Data = data
        };
    }
}
