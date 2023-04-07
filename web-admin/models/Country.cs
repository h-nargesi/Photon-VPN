using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Alpha2Code { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
