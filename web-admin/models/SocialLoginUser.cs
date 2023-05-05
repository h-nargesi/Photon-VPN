using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class SocialLoginUser
{
    public int Id { get; set; }

    public string? Provider { get; set; }

    public string Uid { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string Locale { get; set; } = null!;

    public bool Timezone { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? Gender { get; set; }

    public DateTime? LastConnectTime { get; set; }

    public string ExtraName { get; set; } = null!;

    public string ExtraValue { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
