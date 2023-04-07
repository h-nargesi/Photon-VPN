using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class ApProfile
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? CloudId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool? EnableAlerts { get; set; }

    public bool? EnableOverviews { get; set; }
}
