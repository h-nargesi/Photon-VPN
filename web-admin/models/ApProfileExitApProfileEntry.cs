using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class ApProfileExitApProfileEntry
{
    public int Id { get; set; }

    public int ApProfileExitId { get; set; }

    public int ApProfileEntryId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
