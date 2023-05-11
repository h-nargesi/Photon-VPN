import { UIColors } from '../../components';
import { Payment } from '../../payments/payments.model';

export interface Invoice {
  balance: number,
  plan: Membership | null,
  payments: Payment[],
}

export interface Membership {
  planId: number,
  profileId: number,
  title: string,
  simultaneousUses: number,
  validTime: Date,
  price: number,
  color: UIColors,
  created: Date,
  modified: Date,
}
