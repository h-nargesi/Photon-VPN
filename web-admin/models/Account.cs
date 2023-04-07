using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Account
{
    public int PermanentUserId { get; set; }

    public string Password { get; set; } = null!;

    public virtual PermanentUser PermanentUser { get; set; } = null!;
}
