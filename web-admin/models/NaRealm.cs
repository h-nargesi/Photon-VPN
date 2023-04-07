using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class NaRealm
{
    public int Id { get; set; }

    public int NaId { get; set; }

    public int RealmId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
