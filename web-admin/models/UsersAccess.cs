using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class UsersAccess
{
    public int UserId { get; set; }

    public string EntityName { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
