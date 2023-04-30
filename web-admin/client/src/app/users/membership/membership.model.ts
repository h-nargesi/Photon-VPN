import { UIColors } from "../../components"

export interface PermanentUserPlan {
    permanentUserId: number,
    validTime: Date,
    profileId: number,
    overridePrice: number | null,
    created: Date,
}

export interface Membership {
    planId: number,
    profileId: number,
    name: string,
    validTime: Date,
    price: number,
    color: UIColors,
    created: Date,
    modified: Date,
}
