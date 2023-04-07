using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class UnknownDynamicClient
{
    public int Id { get; set; }

    public string Nasidentifier { get; set; } = null!;

    public string Calledstationid { get; set; } = null!;

    public DateTime? LastContact { get; set; }

    public string LastContactIp { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
