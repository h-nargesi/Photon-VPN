using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class RollingLastSevenDay
{
    public int MeshId { get; set; }

    public int? TreeTagId { get; set; }

    public string? MeshName { get; set; }

    public long? TotClients { get; set; }

    public long? TotTxBytes { get; set; }

    public long? TotRxBytes { get; set; }

    public long? TotBytes { get; set; }

    public long? TotNodes { get; set; }

    public long? TotLvNodes { get; set; }

    public long? TotLvNodesDown { get; set; }

    public long? TotNodesDown { get; set; }

    public long? TotNodesUp { get; set; }

    public long? DualRadios { get; set; }

    public long? SingleRadios { get; set; }

    public float? NupBegRemoveSecs { get; set; }

    public float? NupEndAddSecs { get; set; }

    public float? NupUpSeconds { get; set; }

    public float? NupDownSeconds { get; set; }

    public float? NdwnBegRemoveSecs { get; set; }

    public float? NdwnEndAddSecs { get; set; }

    public float? NdwnUpSeconds { get; set; }

    public float? NdwnDownSeconds { get; set; }
}
