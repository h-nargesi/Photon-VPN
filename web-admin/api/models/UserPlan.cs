namespace Photon.Service.VPN.Handlers.Model;

public class UserPlan
{
    public int UserId { get; set; }

    public int ProfileId { get; set; }

    public int Months { get; set; }

    public decimal? OverridePrice { get; set; }
}
