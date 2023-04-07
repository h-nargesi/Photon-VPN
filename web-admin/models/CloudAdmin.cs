using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class CloudAdmin
{
    public int Id { get; set; }

    public int? CloudId { get; set; }

    public int? UserId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
