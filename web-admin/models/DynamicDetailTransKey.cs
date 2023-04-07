using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class DynamicDetailTransKey
{
    public int Id { get; set; }

    public int? DynamicDetailId { get; set; }

    public string? Name { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Modified { get; set; }
}
