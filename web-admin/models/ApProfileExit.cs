using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class ApProfileExit
{
    public int Id { get; set; }

    public int? ApProfileId { get; set; }

    public string? Type { get; set; }

    public int? Vlan { get; set; }

    public bool AutoDynamicClient { get; set; }

    public string RealmList { get; set; } = null!;

    public bool AutoLoginPage { get; set; }

    public int? DynamicDetailId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int? OpenvpnServerId { get; set; }

    public string? Proto { get; set; }

    public string Ipaddr { get; set; } = null!;

    public string Netmask { get; set; } = null!;

    public string Gateway { get; set; } = null!;

    public string Dns1 { get; set; } = null!;

    public string Dns2 { get; set; } = null!;
}
