using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Plan
{
    public int ProfileId { get; set; }

    public bool Active { get; set; }

    public decimal Price { get; set; }

    public string? ImageFile { get; set; }

    public int Color { get; set; }

    public string? Description { get; set; }

    public DateTime RegisterTime { get; set; }

    public DateTime ModificationTime { get; set; }

    public virtual Profile Profile { get; set; } = null!;
}
