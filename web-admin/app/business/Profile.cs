using System.ComponentModel.DataAnnotations.Schema;

namespace Photon.Service.VPN.Models;

public partial class Profile
{
    [NotMapped]
    public int SimultaneousUses { get; set; } = -1;

    [NotMapped]
    public int? PlanId { get; set; }
}
