using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class EmailMessage
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Message { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
