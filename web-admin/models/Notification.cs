using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Notification
{
    public int Id { get; set; }

    public int Severity { get; set; }

    public bool IsResolved { get; set; }

    public DateTime NotificationDatetime { get; set; }

    public string NotificationType { get; set; } = null!;

    public int NotificationCode { get; set; }

    public string? ShortDescription { get; set; }

    public string? Description { get; set; }

    public int? ItemId { get; set; }

    public string? ItemTable { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
