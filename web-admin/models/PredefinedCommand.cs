using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class PredefinedCommand
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string Command { get; set; } = null!;

    public string? Action { get; set; }

    public int? CloudId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
