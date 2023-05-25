import { Component } from '@angular/core';
import { BaseComponent, EntitySchema, Result, ResultStatus } from '../../components';
import { User } from '../info/users.model';
import { Invoice, Membership, UserPlanRequest } from './membership.model';
import { MembershipService } from './membership.service';
import Titles from './membership.json';
import PaymentTitles from '../../payments/payments.json';
import { ProfilesService } from '../../plans/profiles.service';
import { Payment } from '../../payments/payments.model';

@Component({
  selector: 'app-user-invoice',
  templateUrl: './membership.component.html',
})
export class MembershipComponent extends BaseComponent {

  columns_info: EntitySchema = Titles.list;
  payment_columns_info: EntitySchema = PaymentTitles.list;
  UserItem: User = {} as User;
  Invoices: Invoice[] = [];
  Item: UserPlanRequest = MembershipComponent.InitalizeModel();

  constructor(
    private readonly service: MembershipService,
    public readonly profile_srv: ProfilesService,
  ) {
    super();
  }

  Reload(user: User | undefined = undefined): void {
    if (user) this.UserItem = user;

    if (!this.UserItem || !this.UserItem.id) {
      throw 'user-id is not set';
    }

    if (this.UserItem.profileId)
      this.Item.profileId = this.UserItem.profileId;

    this.service.Balance(this.UserItem.id).subscribe((result: Invoice[]) => this.Invoices = result);
  }

  Submit() {
    if (!this.UserItem || !this.UserItem.id) {
      throw 'user-id is not set';
    }

    this.Item.permanentUserId = this.UserItem.id;

    console.log(this.Item);

    this.service.Add(this.Item).subscribe((result: Result) => {
      if (result.status < ResultStatus.Info) {
        this.Item = MembershipComponent.InitalizeModel();
        if (this.UserItem.profileId)
          this.Item.profileId = this.UserItem.profileId;
        this.Reload();
      }
    });
  }

  Delete(datetime: Date | undefined) {
    if (!datetime) return;
    this.service.Delete(this.UserItem.id, datetime).subscribe((result: Result) => {
      if (result.status < ResultStatus.Invalid) {
        this.Reload();
      }
    });
  }

  static InitalizeModel(): UserPlanRequest {
    return {
      months: 1,
    } as UserPlanRequest;
  }

  PaymentSum(payments: Payment[]): number {
    if (!payments) return 0;
    let value = 0;
    for (const payment of payments)
      value += payment.value ?? 0;
    return value;
  }
}
