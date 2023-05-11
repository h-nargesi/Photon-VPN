
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Photon.Service.VPN.Models;

public partial class Plan
{
    [NotMapped]
    public ICollection<int> SessionCounts { get; set; } = new List<int>();

    [NotMapped]
    public IDictionary<string, Radgroupcheck> Checks { get; set; } = new Dictionary<string, Radgroupcheck>();

    [NotMapped]
    public IDictionary<string, Radgroupreply> Replies { get; set; } = new Dictionary<string, Radgroupreply>();

    [NotMapped]
    [JsonIgnore]
    public ICollection<Profile> Profiles { get; set; } = null!;
}
