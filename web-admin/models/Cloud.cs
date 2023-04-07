using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Cloud
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int? UserId { get; set; }

    public decimal? Lat { get; set; }

    public decimal? Lng { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
