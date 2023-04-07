using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class TempFlowLog
{
    public int Id { get; set; }

    public int? NodeId { get; set; }

    public int? MeshId { get; set; }

    public int? ApId { get; set; }

    public int? ApProfileId { get; set; }

    public string Username { get; set; } = null!;

    public int Proto { get; set; }

    public string SrcMac { get; set; } = null!;

    public string SrcIp { get; set; } = null!;

    public int SrcPort { get; set; }

    public string DstIp { get; set; } = null!;

    public int DstPort { get; set; }

    public int OctIn { get; set; }

    public int PcktIn { get; set; }

    public int OctOut { get; set; }

    public int PcktOut { get; set; }

    public DateTime Start { get; set; }

    public DateTime Finish { get; set; }

    public DateTime Timestamp { get; set; }
}
