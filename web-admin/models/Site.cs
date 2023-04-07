using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Site
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? CloudId { get; set; }

    public decimal? Lat { get; set; }

    public decimal? Lng { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
