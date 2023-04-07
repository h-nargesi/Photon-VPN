using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class ApLoad
{
    public int Id { get; set; }

    public int? ApId { get; set; }

    public int? MemTotal { get; set; }

    public int? MemFree { get; set; }

    public string? Uptime { get; set; }

    public string SystemTime { get; set; } = null!;

    public float Load1 { get; set; }

    public float Load2 { get; set; }

    public float Load3 { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
