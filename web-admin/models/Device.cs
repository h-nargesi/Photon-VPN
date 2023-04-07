using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Device
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool Active { get; set; }

    public DateTime? LastAcceptTime { get; set; }

    public DateTime? LastRejectTime { get; set; }

    public string? LastAcceptNas { get; set; }

    public string? LastRejectNas { get; set; }

    public string? LastRejectMessage { get; set; }

    public int? PermanentUserId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int? PercTimeUsed { get; set; }

    public int? PercDataUsed { get; set; }

    public long? DataUsed { get; set; }

    public long? DataCap { get; set; }

    public int? TimeUsed { get; set; }

    public int? TimeCap { get; set; }

    public string? TimeCapType { get; set; }

    public string? DataCapType { get; set; }

    public string Realm { get; set; } = null!;

    public int? RealmId { get; set; }

    public string Profile { get; set; } = null!;

    public int? ProfileId { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }
}
