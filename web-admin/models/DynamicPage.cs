using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class DynamicPage
{
    public int Id { get; set; }

    public int DynamicDetailId { get; set; }

    public string Name { get; set; } = null!;

    public string Content { get; set; } = null!;

    public DateTime? Created { get; set; }

    public DateTime? Modified { get; set; }

    public int? DynamicDetailLanguageId { get; set; }

    public string? Language { get; set; }
}
