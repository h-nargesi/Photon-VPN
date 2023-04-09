import { PlanProfile } from "../plans/plans.models";

export interface User {
    Id: number,
    Username: string,
    Password: string,
    Token: string | null,
    Name: string,
    Surname: string,
    Address: string,
    Phone: string,
    Email: string,
    AuthType: string,
    Active: boolean,
    LastAcceptTime: Date | null,
    LastRejectTime: Date | null,
    LastAcceptNas: string | null,
    LastRejectNas: string | null,
    LastRejectMessage: string | null,
    PercTimeUsed: number | null,
    PercDataUsed: number | null,
    DataUsed: number | null,
    DataCap: number | null,
    TimeUsed: number | null,
    TimeCap: number | null,
    TimeCapType: string | null,
    DataCapType: string | null,
    Realm: string,
    RealmId: number | null,
    Profile: string,
    ProfileId: number | null,
    FromDate: Date | null,
    ToDate: Date | null,
    TrackAuth: boolean,
    TrackAcct: boolean | null,
    StaticIp: string,
    ExtraName: string,
    ExtraValue: string,
    CountryId: number | null,
    LanguageId: number | null,
    CloudId: number | null,
    Created: Date,
    Modified: Date
}

export interface PermanentUserPlan
{
    PermanentUserId: number,
    ValidTime: Date,
    ProfileId: number,
    OverridePrice: number | null,
    RegisterTime: Date,
}

export interface Membership extends PlanProfile
{
    PermanentUserPlan: PermanentUserPlan,
}