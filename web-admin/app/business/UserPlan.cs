namespace Photon.Service.VPN.Models;
public class UserPlan
{
    public int? PlanId { get; set; }

    public int ProfileId { get; set; }

    public string Title { get; set; } = null!;

    public int SimultaneousUses { get; set; }

    public DateTime ValidTime { get; set; }

    public decimal Price { get; set; }

    public int Color { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
