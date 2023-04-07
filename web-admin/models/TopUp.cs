using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class TopUp
{
    public int Id { get; set; }

    public int? CloudId { get; set; }

    public int? PermanentUserId { get; set; }

    public long? Data { get; set; }

    public int? Time { get; set; }

    public int? DaysToUse { get; set; }

    public string Comment { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? Type { get; set; }
}
