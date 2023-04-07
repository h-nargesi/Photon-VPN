using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class OpenvpnClient
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string? Password { get; set; }

    public int? Subnet { get; set; }

    public int? Peer1 { get; set; }

    public int? Peer2 { get; set; }

    public int? NaId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
