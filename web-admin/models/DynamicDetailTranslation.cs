using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class DynamicDetailTranslation
{
    public int Id { get; set; }

    public int? DynamicDetailLanguageId { get; set; }

    public int? DynamicDetailTransKeyId { get; set; }

    public string? Value { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
