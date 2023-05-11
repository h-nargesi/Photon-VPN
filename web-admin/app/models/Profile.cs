namespace Photon.Service.VPN.Models;

public partial class Profile
{
    public int SimultaneousUses { get; set; } = 0;
    
    public int? PlanId { get; set; }
}
