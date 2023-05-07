namespace Photon.Service.VPN.Models;

public partial class Plan
{
    public ICollection<Profile> Profiles { get; } = new List<Profile>();

    public IDictionary<string, Radgroupcheck> Checks { get; } = new Dictionary<string, Radgroupcheck>();

    public IDictionary<string, Radgroupreply> Replies { get; } = new Dictionary<string, Radgroupreply>();
}
