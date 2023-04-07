using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class PptpClient
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string? Password { get; set; }

    public string? Ip { get; set; }

    public int? NaId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
