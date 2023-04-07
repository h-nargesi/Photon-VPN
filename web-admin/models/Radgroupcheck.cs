using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Radgroupcheck
{
    public uint Id { get; set; }

    public string Groupname { get; set; } = null!;

    public string Attribute { get; set; } = null!;

    public string Op { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string Comment { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
