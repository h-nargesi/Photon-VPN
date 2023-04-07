using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class DynamicPair
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;

    public int Priority { get; set; }

    public int? DynamicDetailId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
