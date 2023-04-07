using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class ScheduleEntry
{
    public int Id { get; set; }

    public int? ScheduleId { get; set; }

    public string Description { get; set; } = null!;

    public string? Type { get; set; }

    public string Command { get; set; } = null!;

    public int? PredefinedCommandId { get; set; }

    public bool Mo { get; set; }

    public bool Tu { get; set; }

    public bool We { get; set; }

    public bool Th { get; set; }

    public bool Fr { get; set; }

    public bool Sa { get; set; }

    public bool Su { get; set; }

    public string EventTime { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
