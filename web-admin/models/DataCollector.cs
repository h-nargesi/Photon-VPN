using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class DataCollector
{
    public int Id { get; set; }

    public int? DynamicDetailId { get; set; }

    public string Email { get; set; } = null!;

    public string Mac { get; set; } = null!;

    public string? CpMac { get; set; }

    public string? PublicIp { get; set; }

    public string? Nasid { get; set; }

    public string? Ssid { get; set; }

    public bool IsMobile { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string Phone { get; set; } = null!;

    public string Dn { get; set; } = null!;

    public bool PhoneOptIn { get; set; }

    public bool EmailOptIn { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Gender { get; set; }

    public DateTime? Birthday { get; set; }

    public string Company { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Room { get; set; } = null!;

    public string Custom1 { get; set; } = null!;

    public string Custom2 { get; set; } = null!;

    public string Custom3 { get; set; } = null!;
}
