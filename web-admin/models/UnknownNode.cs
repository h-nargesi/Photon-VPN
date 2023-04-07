using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class UnknownNode
{
    public uint Id { get; set; }

    public string Mac { get; set; } = null!;

    public string? Vendor { get; set; }

    public string FromIp { get; set; } = null!;

    public bool? Gateway { get; set; }

    public DateTime? LastContact { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string NewServer { get; set; } = null!;

    public string? NewServerStatus { get; set; }

    public string Name { get; set; } = null!;

    public int? FirmwareKeyId { get; set; }

    public string? NewServerProtocol { get; set; }

    public string? NewMode { get; set; }

    public string? NewModeStatus { get; set; }
}
