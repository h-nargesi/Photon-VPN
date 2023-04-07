using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Radpostauth
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string? Realm { get; set; }

    public string Pass { get; set; } = null!;

    public string Reply { get; set; } = null!;

    public string Nasname { get; set; } = null!;

    public DateTime Authdate { get; set; }
}
