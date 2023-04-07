using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class RegistrationRequest
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string Email { get; set; } = null!;

    public Guid? RegistrationCode { get; set; }

    public string? State { get; set; }

    public DateTime? Expire { get; set; }

    public DateTime? EmailSent { get; set; }

    public Guid? TokenKey { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
