using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Na
{
    public int Id { get; set; }

    public string Nasname { get; set; } = null!;

    public string? Shortname { get; set; }

    public string Nasidentifier { get; set; } = null!;

    public string? Type { get; set; }

    public int? Ports { get; set; }

    public string Secret { get; set; } = null!;

    public string? Server { get; set; }

    public string? Community { get; set; }

    public string? Description { get; set; }

    public string? ConnectionType { get; set; }

    public string Timezone { get; set; } = null!;

    public bool RecordAuth { get; set; }

    public bool IgnoreAcct { get; set; }

    public string DynamicAttribute { get; set; } = null!;

    public string DynamicValue { get; set; } = null!;

    public string? Monitor { get; set; }

    public int PingInterval { get; set; }

    public int HeartbeatDeadAfter { get; set; }

    public DateTime? LastContact { get; set; }

    public bool SessionAutoClose { get; set; }

    public int SessionDeadTime { get; set; }

    public bool OnPublicMaps { get; set; }

    public double? Lat { get; set; }

    public double? Lon { get; set; }

    public string PhotoFileName { get; set; } = null!;

    public int? CloudId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
