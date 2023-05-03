using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class PermanentUserPlan
{
    public int PermanentUserId { get; set; }

    public int ProfileId { get; set; }

    public int Periods { get; set; }

    public DateTime ValidTime { get; set; }

    public decimal? OverridePrice { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual PermanentUser PermanentUser { get; set; } = null!;

    public virtual Profile Profile { get; set; } = null!;
}
