import { UIColors } from '../components';

export interface PlanProfile {
    id: number,
    profile: Profile,
    plan: Plan,
}

export interface Profile {
    id: number,
    name: string,
    cloudId: number | null,
    created: Date,
    modified: Date
}

export interface Plan {
    profileId: number,
    active: boolean | null,
    price: number,
    imageFile: string | null,
    description: string | null,
    color: UIColors,
    registerTime: Date,
    modificationTime: Date,
}

export interface PlanModel {
    id: number,
    name: string,
    active: boolean,
    price: number,
    imageFile: string | null,
    color: UIColors,
    speed: string,
    traffic: string,
    description: string | null,
    registerTime: Date,
    modificationTime: Date,
}
