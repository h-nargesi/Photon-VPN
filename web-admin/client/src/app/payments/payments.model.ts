export interface Payment {
    id: number,
    permanentUserId: number,
    approved: boolean,
    value: number,
    trnsactionId: string,
    dateTime: Date,
    bankName: string,
    bankAccount: string,
    created: Date
}