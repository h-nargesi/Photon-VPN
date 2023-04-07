using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class DynamicClient
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Nasidentifier { get; set; } = null!;

    public string Calledstationid { get; set; } = null!;

    public DateTime? LastContact { get; set; }

    public string LastContactIp { get; set; } = null!;

    public string Timezone { get; set; } = null!;

    public string? Monitor { get; set; }

    public bool SessionAutoClose { get; set; }

    public int SessionDeadTime { get; set; }

    public bool? Active { get; set; }

    public bool OnPublicMaps { get; set; }

    public double? Lat { get; set; }

    public double? Lon { get; set; }

    public string PhotoFileName { get; set; } = null!;

    public int? CloudId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool DataLimitActive { get; set; }

    public float DataLimitAmount { get; set; }

    public string? DataLimitUnit { get; set; }

    public int DataLimitResetOn { get; set; }

    public int DataLimitResetHour { get; set; }

    public int DataLimitResetMinute { get; set; }

    public long? DataUsed { get; set; }

    public string? DataLimitCap { get; set; }

    public bool DailyDataLimitActive { get; set; }

    public float DailyDataLimitAmount { get; set; }

    public string? DailyDataLimitUnit { get; set; }

    public string? DailyDataLimitCap { get; set; }

    public int DailyDataLimitResetHour { get; set; }

    public int DailyDataLimitResetMinute { get; set; }

    public long? DailyDataUsed { get; set; }

    public int DefaultVlan { get; set; }

    public string DefaultKey { get; set; } = null!;

    public string? Type { get; set; }
}
