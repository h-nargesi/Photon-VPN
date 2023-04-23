using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Package
{
    public int ProfileId { get; set; }

    public int PlanId { get; set; }

    public virtual Plan Plan { get; set; } = null!;

    public virtual Profile Profile { get; set; } = null!;
}
