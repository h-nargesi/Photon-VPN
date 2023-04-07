using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class MeshExitCaptivePortal
{
    public int Id { get; set; }

    public int MeshExitId { get; set; }

    public string Radius1 { get; set; } = null!;

    public string Radius2 { get; set; } = null!;

    public string RadiusSecret { get; set; } = null!;

    public string RadiusNasid { get; set; } = null!;

    public string UamUrl { get; set; } = null!;

    public string UamSecret { get; set; } = null!;

    public string WalledGarden { get; set; } = null!;

    public bool SwapOctets { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool MacAuth { get; set; }

    public bool ProxyEnable { get; set; }

    public string ProxyIp { get; set; } = null!;

    public int ProxyPort { get; set; }

    public string ProxyAuthUsername { get; set; } = null!;

    public string ProxyAuthPassword { get; set; } = null!;

    public string CoovaOptional { get; set; } = null!;

    public bool DnsManual { get; set; }

    public string Dns1 { get; set; } = null!;

    public string Dns2 { get; set; } = null!;

    public bool Uamanydns { get; set; }

    public bool Dnsparanoia { get; set; }

    public bool Dnsdesk { get; set; }

    public int? MeshExitUpstreamId { get; set; }

    public bool SoftflowdEnabled { get; set; }
}
