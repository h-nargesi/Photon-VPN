using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class PermanentUserPlan
{
    public int Id { get; set; }

    public int PermanentUserId { get; set; }

    public DateTime ValidTime { get; set; }

    public int ProfileId { get; set; }

    public decimal? OverridePrice { get; set; }

    public DateTime RegisterTime { get; set; }

    public virtual PermanentUser PermanentUser { get; set; } = null!;

    public virtual Profile Profile { get; set; } = null!;
}
