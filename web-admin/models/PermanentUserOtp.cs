using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class PermanentUserOtp
{
    public int Id { get; set; }

    public int PermanentUserId { get; set; }

    public string? Status { get; set; }

    public string Value { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
