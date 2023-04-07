using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class NodeIbssConnection
{
    public int Id { get; set; }

    public int? NodeId { get; set; }

    public int? StationNodeId { get; set; }

    public sbyte RadioNumber { get; set; }

    public string? FrequencyBand { get; set; }

    public string IfMac { get; set; } = null!;

    public string Mac { get; set; } = null!;

    public long TxBytes { get; set; }

    public long RxBytes { get; set; }

    public long TxPackets { get; set; }

    public long RxPackets { get; set; }

    public int TxBitrate { get; set; }

    public int RxBitrate { get; set; }

    public sbyte Authenticated { get; set; }

    public sbyte Authorized { get; set; }

    public sbyte TdlsPeer { get; set; }

    public string Preamble { get; set; } = null!;

    public int TxFailed { get; set; }

    public sbyte WmmWme { get; set; }

    public int TxRetries { get; set; }

    public sbyte Mfp { get; set; }

    public int SignalNow { get; set; }

    public int SignalAvg { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
