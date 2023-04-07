using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Voucher
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string Batch { get; set; } = null!;

    public string? Status { get; set; }

    public int? PercTimeUsed { get; set; }

    public int? PercDataUsed { get; set; }

    public DateTime? LastAcceptTime { get; set; }

    public DateTime? LastRejectTime { get; set; }

    public string? LastAcceptNas { get; set; }

    public string? LastRejectNas { get; set; }

    public string? LastRejectMessage { get; set; }

    public int? CloudId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string ExtraName { get; set; } = null!;

    public string ExtraValue { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Realm { get; set; } = null!;

    public int? RealmId { get; set; }

    public string Profile { get; set; } = null!;

    public int? ProfileId { get; set; }

    public DateTime? Expire { get; set; }

    public string TimeValid { get; set; } = null!;

    public long? DataUsed { get; set; }

    public long? DataCap { get; set; }

    public int? TimeUsed { get; set; }

    public int? TimeCap { get; set; }
}
