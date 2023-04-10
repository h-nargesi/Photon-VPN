export interface Server {
    Id: number,
    Nasname: string,
    Shortname: string | null,
    Nasidentifier: string,
    Type: string | null,
    Ports: number | null,
    Secret: string,
    Server: string | null,
    Community: string | null,
    Description: string | null,
    ConnectionType: string | null,
    Timezone: string,
    RecordAuth: boolean,
    IgnoreAcct: boolean,
    DynamicAttribute: string,
    DynamicValue: string,
    Monitor: string | null,
    PingInterval: number,
    HeartbeatDeadAfter: number,
    LastContact: Date | null,
    SessionAutoClose: boolean,
    SessionDeadTime: number,
    OnPublicMaps: boolean,
    Lat: number | null,
    Lon: number | null,
    PhotoFileName: string,
    CloudId: number | null,
    Created: Date,
    Modified: Date
}