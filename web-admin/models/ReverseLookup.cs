using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class ReverseLookup
{
    public int Id { get; set; }

    public string Ip { get; set; } = null!;

    public string Fqdn { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
