using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Mesh
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Ssid { get; set; } = null!;

    public string Bssid { get; set; } = null!;

    public int? CloudId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int? TreeTagId { get; set; }

    public DateTime? LastContact { get; set; }

    public bool? EnableAlerts { get; set; }

    public bool? EnableOverviews { get; set; }
}
