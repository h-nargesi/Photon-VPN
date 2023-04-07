using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class OpenvpnServer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int? CloudId { get; set; }

    public string? LocalRemote { get; set; }

    public string? Protocol { get; set; }

    public string IpAddress { get; set; } = null!;

    public int Port { get; set; }

    public string VpnGatewayAddress { get; set; } = null!;

    public string VpnBridgeStartAddress { get; set; } = null!;

    public string VpnMask { get; set; } = null!;

    public string ConfigPreset { get; set; } = null!;

    public string CaCrt { get; set; } = null!;

    public string ExtraName { get; set; } = null!;

    public string ExtraValue { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
