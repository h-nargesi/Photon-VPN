using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class OpenvpnServerClient
{
    public int Id { get; set; }

    public string? MeshApProfile { get; set; }

    public int? OpenvpnServerId { get; set; }

    public int? MeshId { get; set; }

    public int? MeshExitId { get; set; }

    public int? ApProfileId { get; set; }

    public int? ApProfileExitId { get; set; }

    public int? ApId { get; set; }

    public string IpAddress { get; set; } = null!;

    public DateTime? LastContactToServer { get; set; }

    public bool State { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
