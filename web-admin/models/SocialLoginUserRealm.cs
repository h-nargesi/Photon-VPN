using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class SocialLoginUserRealm
{
    public int Id { get; set; }

    public int? SocialLoginUserId { get; set; }

    public int? RealmId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
