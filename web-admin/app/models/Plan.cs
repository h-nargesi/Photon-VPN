
using System.ComponentModel.DataAnnotations.Schema;

namespace Photon.Service.VPN.Models;

public partial class Plan
{
    [NotMapped]
    public ICollection<int> SessionCounts { get; internal set; } = new List<int>();

    [NotMapped]
    public IDictionary<string, Radgroupcheck> Checks { get; internal set; } = new Dictionary<string, Radgroupcheck>();

    [NotMapped]
    public IDictionary<string, Radgroupreply> Replies { get; internal set; } = new Dictionary<string, Radgroupreply>();
}
