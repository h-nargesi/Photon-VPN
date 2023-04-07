using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Hardware
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Vendor { get; set; } = null!;

    public string Model { get; set; } = null!;

    public string FwId { get; set; } = null!;

    public bool? ForMesh { get; set; }

    public bool? ForAp { get; set; }

    public string Wan { get; set; } = null!;

    public string? Lan { get; set; }

    public sbyte RadioCount { get; set; }

    public string PhotoFileName { get; set; } = null!;

    public int? CloudId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
