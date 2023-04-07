using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class MeshExitMeshEntry
{
    public int Id { get; set; }

    public int MeshExitId { get; set; }

    public int MeshEntryId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
