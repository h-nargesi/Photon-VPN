using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class ArNodeIbssConnection
{
    public int Id { get; set; }

    public int? NodeId { get; set; }

    public int? StationNodeId { get; set; }

    public string? Vendor { get; set; }

    public string Mac { get; set; } = null!;

    public long TxBytes { get; set; }

    public long RxBytes { get; set; }

    public int TxPackets { get; set; }

    public int RxPackets { get; set; }

    public int TxBitrate { get; set; }

    public int RxBitrate { get; set; }

    public string TxExtraInfo { get; set; } = null!;

    public string RxExtraInfo { get; set; } = null!;

    public string? Authenticated { get; set; }

    public string? Authorized { get; set; }

    public string TdlsPeer { get; set; } = null!;

    public string? Preamble { get; set; }

    public int TxFailed { get; set; }

    public int InactiveTime { get; set; }

    public string? WmmWme { get; set; }

    public int TxRetries { get; set; }

    public string? Mfp { get; set; }

    public int SignalNow { get; set; }

    public int SignalAvg { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
