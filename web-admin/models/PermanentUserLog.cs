using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class PermanentUserLog
{
    public int Id { get; set; }

    public int PermanentUserId { get; set; }

    public int Witer { get; set; }

    public string Content { get; set; } = null!;

    public DateTime RegisterTime { get; set; }

    public virtual PermanentUser PermanentUser { get; set; } = null!;

    public virtual User WiterNavigation { get; set; } = null!;
}
