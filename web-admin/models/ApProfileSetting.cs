using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class ApProfileSetting
{
    public int Id { get; set; }

    public int? ApProfileId { get; set; }

    public string Password { get; set; } = null!;

    public int HeartbeatInterval { get; set; }

    public int HeartbeatDeadAfter { get; set; }

    public string PasswordHash { get; set; } = null!;

    public string TzName { get; set; } = null!;

    public string TzValue { get; set; } = null!;

    public string Country { get; set; } = null!;

    public int GwDhcpTimeout { get; set; }

    public bool? GwUsePrevious { get; set; }

    public bool? GwAutoReboot { get; set; }

    public int GwAutoRebootTime { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string Syslog1Ip { get; set; } = null!;

    public string Syslog1Port { get; set; } = null!;

    public string Syslog2Ip { get; set; } = null!;

    public string Syslog2Port { get; set; } = null!;

    public string Syslog3Ip { get; set; } = null!;

    public string Syslog3Port { get; set; } = null!;

    public bool? ReportAdvEnable { get; set; }

    public string? ReportAdvProto { get; set; }

    public int? ReportAdvLight { get; set; }

    public int? ReportAdvFull { get; set; }

    public int? ReportAdvSampling { get; set; }

    public bool EnableSchedules { get; set; }

    public int? ScheduleId { get; set; }

    public bool VlanEnable { get; set; }

    public string? VlanRangeOrList { get; set; }

    public int VlanStart { get; set; }

    public int VlanEnd { get; set; }

    public string VlanList { get; set; } = null!;
}
