using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class Radacct
{
    public long Radacctid { get; set; }

    public string Acctsessionid { get; set; } = null!;

    public string Acctuniqueid { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Groupname { get; set; } = null!;

    public string? Realm { get; set; }

    public string Nasipaddress { get; set; } = null!;

    public string Nasidentifier { get; set; } = null!;

    public string? Nasportid { get; set; }

    public string? Nasporttype { get; set; }

    public DateTime? Acctstarttime { get; set; }

    public DateTime? Acctupdatetime { get; set; }

    public DateTime? Acctstoptime { get; set; }

    public int? Acctinterval { get; set; }

    public uint? Acctsessiontime { get; set; }

    public string? Acctauthentic { get; set; }

    public string? ConnectinfoStart { get; set; }

    public string? ConnectinfoStop { get; set; }

    public long? Acctinputoctets { get; set; }

    public long? Acctoutputoctets { get; set; }

    public string Calledstationid { get; set; } = null!;

    public string Callingstationid { get; set; } = null!;

    public string Acctterminatecause { get; set; } = null!;

    public string? Servicetype { get; set; }

    public string? Framedprotocol { get; set; }

    public string Framedipaddress { get; set; } = null!;

    public int? Acctstartdelay { get; set; }

    public int? Acctstopdelay { get; set; }

    public string? Xascendsessionsvrkey { get; set; }
}
