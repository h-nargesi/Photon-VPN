using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class ApAction
{
    public int Id { get; set; }

    public int ApId { get; set; }

    public string? Action { get; set; }

    public string? Command { get; set; }

    public string? Status { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? Reply { get; set; }
}
