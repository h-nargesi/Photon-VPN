import { UIColors } from '../components';

export interface Plan {
    id: number,
    active: boolean,
    title: string,
    price: number,
    imageFile: string | null,
    description: string | null,
    color: UIColors,
    created: Date,
    modified: Date,
}

export interface PlanModel {
    id: number,
    title: string,
    active: boolean,
    price: number,
    imageFile: string | null,
    color: UIColors,
    speed: string,
    traffic: string,
    created: Date,
    modified: Date,
}

export interface Profile {
    id: number,
    name: string,
    cloudId: number | null,
    created: Date,
    modified: Date
}
