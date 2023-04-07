using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class TempProxyLog
{
    public int Id { get; set; }

    public int? NodeId { get; set; }

    public int? MeshId { get; set; }

    public string Username { get; set; } = null!;

    public string Host { get; set; } = null!;

    public string SourceIp { get; set; } = null!;

    public string Mac { get; set; } = null!;

    public string? FullString { get; set; }

    public string? FullUrl { get; set; }

    public DateTime Timestamp { get; set; }
}
