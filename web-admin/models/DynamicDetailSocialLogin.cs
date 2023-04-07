using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class DynamicDetailSocialLogin
{
    public int Id { get; set; }

    public int DynamicDetailId { get; set; }

    public int ProfileId { get; set; }

    public int RealmId { get; set; }

    public string Name { get; set; } = null!;

    public bool Enable { get; set; }

    public bool RecordInfo { get; set; }

    public string SpecialKey { get; set; } = null!;

    public string Secret { get; set; } = null!;

    public string? Type { get; set; }

    public string ExtraName { get; set; } = null!;

    public string ExtraValue { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
