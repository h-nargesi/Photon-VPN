import { Component } from '@angular/core';
import { User } from '../info/users.model';
import { Invoice, Membership } from './membership.model';
import { MembershipService } from './membership.service';

@Component({
  selector: 'app-user-invoice',
  templateUrl: './membership.component.html',
})
export class MembershipComponent {

  UserItem: User = {} as User;
  Invoices: Invoice[] = [];
  Item: Membership = MembershipComponent.InitalizeModel();

  constructor(private readonly service: MembershipService) { }

  Reload(user: User | undefined = undefined): void {
    if (user) this.UserItem = user;

    if (!this.UserItem || !this.UserItem.id) {
      throw 'user-id is not set';
    }

    this.service.Balance(this.UserItem.id).subscribe((result: Invoice[]) => this.Invoices = result);
  }

  static InitalizeModel(): Membership {
    return {
    } as Membership;
  }
}
