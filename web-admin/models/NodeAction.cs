using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class NodeAction
{
    public int Id { get; set; }

    public int NodeId { get; set; }

    public string? Action { get; set; }

    public string? Command { get; set; }

    public string? Status { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? Reply { get; set; }
}
