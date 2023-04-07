using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Radippool
{
    public uint Id { get; set; }

    public string PoolName { get; set; } = null!;

    public string Framedipaddress { get; set; } = null!;

    public string Nasipaddress { get; set; } = null!;

    public string Calledstationid { get; set; } = null!;

    public string Callingstationid { get; set; } = null!;

    public DateTime? ExpiryTime { get; set; }

    public string Username { get; set; } = null!;

    public string PoolKey { get; set; } = null!;

    public string Nasidentifier { get; set; } = null!;

    public string ExtraName { get; set; } = null!;

    public string ExtraValue { get; set; } = null!;

    public bool? Active { get; set; }

    public int? PermanentUserId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
