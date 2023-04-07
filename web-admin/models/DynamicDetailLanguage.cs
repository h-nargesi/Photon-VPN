using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class DynamicDetailLanguage
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? IsoCode { get; set; }

    public bool Rtl { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Modified { get; set; }
}
