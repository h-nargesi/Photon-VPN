using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class NodeScan
{
    public int Id { get; set; }

    public int? NodeId { get; set; }

    public int? ApId { get; set; }

    public string? ScanData { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
