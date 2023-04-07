using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class MeshSetting
{
    public int Id { get; set; }

    public int? MeshId { get; set; }

    public bool? AggregatedOgms { get; set; }

    public bool ApIsolation { get; set; }

    public bool Bonding { get; set; }

    public bool BridgeLoopAvoidance { get; set; }

    public bool? Fragmentation { get; set; }

    public bool? DistributedArpTable { get; set; }

    public int OrigInterval { get; set; }

    public int GwSelClass { get; set; }

    public string? Connectivity { get; set; }

    public bool Encryption { get; set; }

    public string EncryptionKey { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
