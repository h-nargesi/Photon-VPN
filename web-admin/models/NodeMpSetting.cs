using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class NodeMpSetting
{
    public int Id { get; set; }

    public int? NodeId { get; set; }

    public string? Name { get; set; }

    public string Value { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
