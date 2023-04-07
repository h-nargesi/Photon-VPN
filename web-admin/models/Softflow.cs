using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Softflow
{
    public int Id { get; set; }

    public int? DynamicClientId { get; set; }

    public string? Username { get; set; }

    public string? SrcMac { get; set; }

    public string? SrcIp { get; set; }

    public string? DstIp { get; set; }

    public int? SrcPort { get; set; }

    public int? DstPort { get; set; }

    public int? Proto { get; set; }

    public int? PcktIn { get; set; }

    public int? PcktOut { get; set; }

    public long? OctIn { get; set; }

    public long? OctOut { get; set; }

    public DateTime? Start { get; set; }

    public DateTime? Finish { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
