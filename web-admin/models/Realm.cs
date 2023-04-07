using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Realm
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string IconFileName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Cell { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string StreetNo { get; set; } = null!;

    public string Street { get; set; } = null!;

    public string TownSuburb { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Country { get; set; } = null!;

    public double? Lat { get; set; }

    public double? Lon { get; set; }

    public int? CloudId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string Twitter { get; set; } = null!;

    public string Facebook { get; set; } = null!;

    public string Youtube { get; set; } = null!;

    public string GooglePlus { get; set; } = null!;

    public string Linkedin { get; set; } = null!;

    public string TCTitle { get; set; } = null!;

    public string TCContent { get; set; } = null!;

    public string Suffix { get; set; } = null!;

    public bool SuffixPermanentUsers { get; set; }

    public bool SuffixVouchers { get; set; }

    public bool SuffixDevices { get; set; }
}
