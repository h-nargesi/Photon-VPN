using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Ap
{
    public int Id { get; set; }

    public int? ApProfileId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Mac { get; set; } = null!;

    public string? Hardware { get; set; }

    public string? LastContactFromIp { get; set; }

    public DateTime? LastContact { get; set; }

    public bool OnPublicMaps { get; set; }

    public double? Lat { get; set; }

    public double? Lon { get; set; }

    public string PhotoFileName { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public DateTime? ConfigFetched { get; set; }

    public string LanProto { get; set; } = null!;

    public string LanIp { get; set; } = null!;

    public string LanGw { get; set; } = null!;

    public string? Gateway { get; set; }

    public bool RebootFlag { get; set; }

    public int? TreeTagId { get; set; }

    public bool? EnableAlerts { get; set; }

    public bool? EnableOverviews { get; set; }

    public bool EnableSchedules { get; set; }

    public int? ScheduleId { get; set; }
}
