import { Component } from '@angular/core';
import { BaseComponent, EntitySchema, Result, ResultStatus } from '../../components';
import { User } from '../info/users.model';
import { Invoice, Membership, UserPlanRequest } from './membership.model';
import { MembershipService } from './membership.service';
import Titles from './membership.json';
import { ProfilesService } from '../../plans/profiles.service';

@Component({
  selector: 'app-user-invoice',
  templateUrl: './membership.component.html',
})
export class MembershipComponent extends BaseComponent {

  columns_info: EntitySchema = Titles.list;
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
        this.Reload();
      }
    });
  }

  Delete() {
    //this.service.Delete(this.Item.id).subscribe((result: Result) => {
    //  if (result.status < ResultStatus.Invalid) {
    //    this.Cancel();
    //    this.Reload();
    //  }
    //});
  }

  static InitalizeModel(): UserPlanRequest {
    return {
      months: 1,
    } as UserPlanRequest;
  }
}
