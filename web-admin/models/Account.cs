using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Account
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? PermanentUserId { get; set; }

    public virtual PermanentUser? PermanentUser { get; set; }
}
