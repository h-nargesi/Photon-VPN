using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class NodeMeshExit
{
    public int Id { get; set; }

    public int NodeId { get; set; }

    public int MeshExitId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }
}
