using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class ApUptmHistory
{
    public int Id { get; set; }

    public int? ApId { get; set; }

    public bool ApState { get; set; }

    public DateTime StateDatetime { get; set; }

    public DateTime ReportDatetime { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
