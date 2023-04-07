using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class NaSetting
{
    public int Id { get; set; }

    public int NaId { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
