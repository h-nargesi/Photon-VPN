using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class SmsHistory
{
    public int Id { get; set; }

    public int CloudId { get; set; }

    public string? Recipient { get; set; }

    public string? Reason { get; set; }

    public string? Message { get; set; }

    public string? Reply { get; set; }

    public int? SmsProvider { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
