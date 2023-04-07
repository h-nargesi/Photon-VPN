using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class NodeNeighbor
{
    public int Id { get; set; }

    public int? NodeId { get; set; }

    public string? Gateway { get; set; }

    public int? NeighborId { get; set; }

    public decimal Metric { get; set; }

    public string? Hwmode { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
