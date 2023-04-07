using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class ForwardLookup
{
    public int Id { get; set; }

    public string Fqdn { get; set; } = null!;

    public string Ip { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
