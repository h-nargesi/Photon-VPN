using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Alert
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int? NodeId { get; set; }

    public int? MeshId { get; set; }

    public int? ApId { get; set; }

    public int? ApProfileId { get; set; }

    public DateTime Detected { get; set; }

    public DateTime? Acknowledged { get; set; }

    public int? UserId { get; set; }

    public DateTime? Resolved { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
