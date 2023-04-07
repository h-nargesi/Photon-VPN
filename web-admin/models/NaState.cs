using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class NaState
{
    public int Id { get; set; }

    public Guid NaId { get; set; }

    public bool State { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
