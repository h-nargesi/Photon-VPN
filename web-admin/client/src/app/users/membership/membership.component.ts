import { Component, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { TableViewComponent } from '../components';
import { RealmsService } from '../global-services/realms.service';
import { PaymentsService } from '../payments/payments.service';
import { ProfilesService } from '../profiles/profiles.service';
import { User } from './users.model';
import { UsersService } from './users.service';

@Component({
  selector: 'app-user-log',
  templateUrl: './membership.component.html',
})
export class MembershipComponent {

  private sub: any;
  public Item: User = {} as User;
  @ViewChild('PaymentView') private payment_list: TableViewComponent | undefined;

  constructor(
    private readonly service: UsersService,
    private readonly payment_srv: PaymentsService,
    private readonly route: ActivatedRoute,
    public readonly profile_srv: ProfilesService,
    public readonly realms_srv: RealmsService) {
  }

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
      if ('id' in params) {
        this.service.Get(+params['id']).subscribe({
          next: (result: User) => this.Item = result,
          error: console.error
        });
      }
    });

    this.payment_srv?.List(null).subscribe({
      next: (result: any[]) => this.payment_list?.SetDataSource(result),
      error: console.error
    });
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }

}
