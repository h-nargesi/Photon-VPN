using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class UserSsid
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Ssidname { get; set; } = null!;

    public int Priority { get; set; }
}
