using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Plan
{
    public int Id { get; set; }

    public bool Active { get; set; }

    public string Title { get; set; } = null!;

    public decimal Price { get; set; }

    public string? ImageFile { get; set; }

    public int Color { get; set; }

    public string? Description { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual ICollection<Package> Packages { get; } = new List<Package>();
}
