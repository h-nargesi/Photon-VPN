using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class PermanentUserNotification
{
    public int Id { get; set; }

    public int? PermanentUserId { get; set; }

    public bool? Active { get; set; }

    public string? Method { get; set; }

    public string? Type { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public int? Start { get; set; }

    public int? Increment { get; set; }

    public int? LastValue { get; set; }

    public DateTime? LastNotification { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
