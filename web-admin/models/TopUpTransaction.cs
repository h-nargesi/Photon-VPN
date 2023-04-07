using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class TopUpTransaction
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? PermanentUserId { get; set; }

    public string? PermanentUser { get; set; }

    public int? TopUpId { get; set; }

    public string? Type { get; set; }

    public string? Action { get; set; }

    public string RadiusAttribute { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
