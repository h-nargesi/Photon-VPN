using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Schedule
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? CloudId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
