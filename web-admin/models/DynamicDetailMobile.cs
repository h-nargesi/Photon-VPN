using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class DynamicDetailMobile
{
    public int Id { get; set; }

    public int? DynamicDetailId { get; set; }

    public bool MobileOnly { get; set; }

    public string Content { get; set; } = null!;

    public bool AndroidEnable { get; set; }

    public string AndroidHref { get; set; } = null!;

    public string AndroidText { get; set; } = null!;

    public string AndroidContent { get; set; } = null!;

    public bool AppleEnable { get; set; }

    public string AppleHref { get; set; } = null!;

    public string AppleText { get; set; } = null!;

    public string AppleContent { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
