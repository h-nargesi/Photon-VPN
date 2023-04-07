using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class DynamicDetailPrelogin
{
    public int Id { get; set; }

    public string Mac { get; set; } = null!;

    public string Nasid { get; set; } = null!;

    public int DynamicDetailId { get; set; }

    public bool Completed { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
