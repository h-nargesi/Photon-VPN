using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Node
{
    public int Id { get; set; }

    public int? MeshId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Mac { get; set; } = null!;

    public string? Hardware { get; set; }

    public string? Ip { get; set; }

    public DateTime? LastContact { get; set; }

    public double? Lat { get; set; }

    public double? Lon { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public DateTime? ConfigFetched { get; set; }

    public string LanProto { get; set; } = null!;

    public string LanIp { get; set; } = null!;

    public string LanGw { get; set; } = null!;

    public string LastContactFromIp { get; set; } = null!;

    public string Mesh0 { get; set; } = null!;

    public string Mesh1 { get; set; } = null!;

    public string Mesh2 { get; set; } = null!;

    public string? Gateway { get; set; }

    public int Bootcycle { get; set; }

    public string? Mesh0FrequencyBand { get; set; }

    public string? Mesh1FrequencyBand { get; set; }

    public string? Mesh2FrequencyBand { get; set; }

    public int Mesh0Channel { get; set; }

    public int Mesh1Channel { get; set; }

    public int Mesh2Channel { get; set; }

    public int Mesh0Txpower { get; set; }

    public int Mesh1Txpower { get; set; }

    public int Mesh2Txpower { get; set; }

    public bool RebootFlag { get; set; }

    public bool? EnableAlerts { get; set; }

    public bool? EnableOverviews { get; set; }

    public bool EnableSchedules { get; set; }

    public int? ScheduleId { get; set; }
}
