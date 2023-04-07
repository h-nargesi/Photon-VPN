using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class AppliedFupComponent
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public int ProfileFupComponentId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
