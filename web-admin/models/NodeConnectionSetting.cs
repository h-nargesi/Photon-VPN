using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class NodeConnectionSetting
{
    public int Id { get; set; }

    public int? NodeId { get; set; }

    public string? Grouping { get; set; }

    public string? Name { get; set; }

    public string? Value { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
