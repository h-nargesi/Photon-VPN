using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class MeshDailySummary
{
    public int Id { get; set; }

    public int MeshId { get; set; }

    public DateOnly TheDate { get; set; }

    public int? TreeTagId { get; set; }

    public string? MeshName { get; set; }

    public long? MinClients { get; set; }

    public long? MaxClients { get; set; }

    public long? MinNodes { get; set; }

    public long? MaxNodes { get; set; }

    public long? MinLvNodes { get; set; }

    public long? MaxLvNodes { get; set; }

    public long? MinLvNodesDown { get; set; }

    public long? MaxLvNodesDown { get; set; }

    public long? MinNodesDown { get; set; }

    public long? MaxNodesDown { get; set; }

    public long? MinNodesUp { get; set; }

    public long? MaxNodesUp { get; set; }

    public long? MinDualRadios { get; set; }

    public long? MaxDualRadios { get; set; }

    public long? MinSingleRadios { get; set; }

    public long? MaxSingleRadios { get; set; }
}
