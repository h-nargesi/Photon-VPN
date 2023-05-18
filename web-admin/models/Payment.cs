using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Payment
{
    public int Id { get; set; }

    public int PermanentUserId { get; set; }

    public bool Approved { get; set; }

    public decimal Value { get; set; }

    public string? TrnsactionId { get; set; }

    public DateTime? DateTime { get; set; }

    public string? BankName { get; set; }

    public string? BankAccount { get; set; }

    public DateTime Modified { get; set; }

    public DateTime Created { get; set; }

    public virtual PermanentUser PermanentUser { get; set; } = null!;
}
