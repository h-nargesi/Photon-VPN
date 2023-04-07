using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class ProfileFupComponent
{
    public int Id { get; set; }

    public int ProfileId { get; set; }

    public string Name { get; set; } = null!;

    public string? IfCondition { get; set; }

    public string? TimeStart { get; set; }

    public string? TimeEnd { get; set; }

    public int? DataAmount { get; set; }

    public string? DataUnit { get; set; }

    public string? Action { get; set; }

    public int? ActionAmount { get; set; }

    public string? IpPool { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
