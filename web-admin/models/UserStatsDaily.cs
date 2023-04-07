using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class UserStatsDaily
{
    public int Id { get; set; }

    public int UserStatId { get; set; }

    public string Username { get; set; } = null!;

    public string? Realm { get; set; }

    public string Nasidentifier { get; set; } = null!;

    public string Callingstationid { get; set; } = null!;

    public DateTime Timestamp { get; set; }

    public long Acctinputoctets { get; set; }

    public long Acctoutputoctets { get; set; }
}
