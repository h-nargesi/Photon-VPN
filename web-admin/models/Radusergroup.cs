using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Radusergroup
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Groupname { get; set; } = null!;

    public int Priority { get; set; }
}
