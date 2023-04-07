using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class MacUsage
{
    public int Id { get; set; }

    public string Mac { get; set; } = null!;

    public string Username { get; set; } = null!;

    public long? DataUsed { get; set; }

    public long? DataCap { get; set; }

    public int? TimeUsed { get; set; }

    public int? TimeCap { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
