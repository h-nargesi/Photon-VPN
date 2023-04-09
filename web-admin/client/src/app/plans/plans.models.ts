export interface PlanProfile {
    Profile: Profile,
    Plan: Plan,
}

export interface Profile {
    Id: number,
    Name: string,
    CloudId: number | null,
    Created: Date,
    Modified: Date
}

export interface Plan {
    ProfileId: number,
    Active: boolean | null,
    Price: number,
    ImageFile: string | null,
    Description: string | null,
    RegisterTime: Date,
    ModificationTime: Date,
}