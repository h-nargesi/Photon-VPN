namespace Photon.Service.VPN.Handlers.Model;

public class UserPlanRequest
{
    public int PermanentUserId { get; set; }

    public int ProfileId { get; set; }

    public int Months { get; set; }

    public decimal? OverridePrice { get; set; }
}
