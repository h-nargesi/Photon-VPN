using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class MeshEntry
{
    public int Id { get; set; }

    public int? MeshId { get; set; }

    public string Name { get; set; } = null!;

    public bool Hidden { get; set; }

    public bool Isolate { get; set; }

    public bool ApplyToAll { get; set; }

    public string? Encryption { get; set; }

    public string SpecialKey { get; set; } = null!;

    public string AuthServer { get; set; } = null!;

    public string AuthSecret { get; set; } = null!;

    public bool DynamicVlan { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool ChkMaxassoc { get; set; }

    public int? Maxassoc { get; set; }

    public string? Macfilter { get; set; }

    public int PermanentUserId { get; set; }

    public string Nasid { get; set; } = null!;

    public bool AutoNasid { get; set; }

    public bool? Accounting { get; set; }

    public string? FrequencyBand { get; set; }

    public int DefaultVlan { get; set; }

    public string DefaultKey { get; set; } = null!;
}
