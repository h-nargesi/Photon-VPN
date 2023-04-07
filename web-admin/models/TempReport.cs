using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class TempReport
{
    public int Id { get; set; }

    public int MeshId { get; set; }

    public int NodeId { get; set; }

    public int ApId { get; set; }

    public int ApProfileId { get; set; }

    public string? Report { get; set; }

    public DateTime Timestamp { get; set; }
}
