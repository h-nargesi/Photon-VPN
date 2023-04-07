using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Action
{
    public int Id { get; set; }

    public int NaId { get; set; }

    public string? Action1 { get; set; }

    public string? Command { get; set; }

    public string? Status { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
