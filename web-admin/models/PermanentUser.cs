using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class PermanentUser
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public Guid? Token { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string AuthType { get; set; } = null!;

    public bool Active { get; set; }

    public DateTime? LastAcceptTime { get; set; }

    public DateTime? LastRejectTime { get; set; }

    public string? LastAcceptNas { get; set; }

    public string? LastRejectNas { get; set; }

    public string? LastRejectMessage { get; set; }

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

    public bool TrackAuth { get; set; }

    public bool? TrackAcct { get; set; }

    public string StaticIp { get; set; } = null!;

    public string ExtraName { get; set; } = null!;

    public string ExtraValue { get; set; } = null!;

    public int? CountryId { get; set; }

    public int? LanguageId { get; set; }

    public int? CloudId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual Account? Account { get; set; }

    public virtual ICollection<Payment> Payments { get; } = new List<Payment>();

    public virtual ICollection<PermanentUserPlan> PermanentUserPlans { get; } = new List<PermanentUserPlan>();
}
