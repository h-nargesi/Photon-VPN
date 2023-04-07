using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class DynamicPhoto
{
    public int Id { get; set; }

    public int DynamicDetailId { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string FileName { get; set; } = null!;

    public DateTime? Created { get; set; }

    public DateTime? Modified { get; set; }

    public bool? Active { get; set; }

    public string? Fit { get; set; }

    public string BackgroundColor { get; set; } = null!;

    public int SlideDuration { get; set; }

    public bool? IncludeTitle { get; set; }

    public bool? IncludeDescription { get; set; }
}
