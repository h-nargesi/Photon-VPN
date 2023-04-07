using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class DynamicPhotoTranslation
{
    public int Id { get; set; }

    public int? DynamicDetailLanguageId { get; set; }

    public int? DynamicPhotoId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
