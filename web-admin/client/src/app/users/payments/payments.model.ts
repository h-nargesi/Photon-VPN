export interface Payment {
    Id: number,
    PermanentUserId: number,
    Approved: boolean,
    Value: number,
    TrnsactionId: string,
    DateTime: Date,
    BankName: string,
    BankAccount: string,
    RegisterTime: Date
}