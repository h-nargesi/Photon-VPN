using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class ApSystem
{
    public int Id { get; set; }

    public int? ApId { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string Category { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
