using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class UserStat
{
    public int Id { get; set; }

    public int RadacctId { get; set; }

    public string Username { get; set; } = null!;

    public string? Realm { get; set; }

    public string Nasipaddress { get; set; } = null!;

    public string Nasidentifier { get; set; } = null!;

    public string Framedipaddress { get; set; } = null!;

    public string Callingstationid { get; set; } = null!;

    public DateTime Timestamp { get; set; }

    public long Acctinputoctets { get; set; }

    public long Acctoutputoctets { get; set; }
}
