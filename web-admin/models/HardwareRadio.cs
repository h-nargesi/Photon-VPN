using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class HardwareRadio
{
    public int Id { get; set; }

    public sbyte RadioNumber { get; set; }

    public bool Disabled { get; set; }

    public sbyte Txpower { get; set; }

    public bool IncludeBeaconInt { get; set; }

    public int BeaconInt { get; set; }

    public bool IncludeDistance { get; set; }

    public int Distance { get; set; }

    public string? HtCapab { get; set; }

    public bool? Mesh { get; set; }

    public bool? Ap { get; set; }

    public bool? Config { get; set; }

    public int? HardwareId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? Band { get; set; }

    public string? Mode { get; set; }

    public string? Width { get; set; }
}
