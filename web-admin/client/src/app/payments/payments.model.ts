export interface Payment {
  id: number,
  permanentUserId: number,
  approved: boolean,
  value: number,
  trnsactionId: string,
  dateTime: Date,
  bankName: string | null,
  bankAccount: string | null,
  created: Date,
}

export interface PaymentList extends Payment {
  username: string,
}
