export interface Session {
    id: number,
    radacctid: number,
    acctsessionid: string,
    acctuniqueid: string,
    username: string,
    groupname: string,
    realm: string | null,
    nasipaddress: string,
    nasidentifier: string,
    nasportid: string | null,
    nasporttype: string | null,
    acctstarttime: Date | null,
    acctupdatetime: Date | null,
    acctstoptime: Date | null,
    acctinterval: number | null,
    acctsessiontime: number | null,
    acctauthentic: string | null,
    connectinfoStart: string | null,
    connectinfoStop: string | null,
    acctinputoctets: number | null,
    acctoutputoctets: number | null,
    calledstationid: string,
    callingstationid: string,
    acctterminatecause: string,
    servicetype: string | null,
    framedprotocol: string | null,
    framedipaddress: string,
    acctstartdelay: number | null,
    acctstopdelay: number | null,
    xascendsessionsvrkey: string | null
}