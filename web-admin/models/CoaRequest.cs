using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class CoaRequest
{
    public int Id { get; set; }

    public int? NodeId { get; set; }

    public bool MultipleGateways { get; set; }

    public string? AvpJson { get; set; }

    public string? Result { get; set; }

    public string? Status { get; set; }

    public string? RequestType { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
