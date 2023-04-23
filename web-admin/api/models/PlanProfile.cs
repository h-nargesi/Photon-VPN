using Photon.Service.VPN.Models;

namespace Photon.Service.VPN.Handlers.Model;

public class PlanProfile
{
    public int Id { get; set; }

    public Profile? Profile { get; set; }

    public Plan? Plan { get; set; }
}
