﻿using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class NodeStationsDaily
{
    public int Id { get; set; }

    public string Mac { get; set; } = null!;

    public int NodeStationId { get; set; }

    public int MeshId { get; set; }

    public int MeshEntryId { get; set; }

    public int NodeId { get; set; }

    public int RadioNumber { get; set; }

    public string? FrequencyBand { get; set; }

    public long TxBytes { get; set; }

    public long RxBytes { get; set; }

    public int TxBitrate { get; set; }

    public int RxBitrate { get; set; }

    public int SignalAvg { get; set; }

    public DateTime Timestamp { get; set; }
}
