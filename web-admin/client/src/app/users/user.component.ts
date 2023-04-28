import { Component, ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent, EntitySchema, Result, ResultStatus, TableViewComponent } from '../components';
import { ProfilesService } from '../profiles/profiles.service';
import { RealmsService } from '../global-services/realms.service';
import { UsersService } from './users.service';
import { User } from './users.model';
import Titles from './users.json';
import { PaymentsService } from '../payments/payments.service';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
})
export class UserComponent extends BaseComponent {

  private sub: any;
  private item: User = {} as User;
  public columns_info: EntitySchema = Titles.list;
  @ViewChild('PaymentView') private payment_list: TableViewComponent | undefined;

  constructor(
    private readonly service: UsersService,
    private readonly payment_srv: PaymentsService,
    private readonly route: ActivatedRoute,
    private readonly router: Router,
    public readonly profile_srv: ProfilesService,
    public readonly realms_srv: RealmsService) {
    super();
  }

  get Item(): User {
    return this.item;
  }

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
      if ('id' in params) {
        this.service.Get(+params['id']).subscribe({
          next: (result: User) => this.item = result,
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

  Submit() {
    console.log(this.item);

    this.service.Modify(this.item).subscribe({
      next: (result: Result) => {
        if (result.status >= ResultStatus.Invalid) console.error(result);
        else {
          console.info(result);
          if (!this.item.id) this.item.id = Number(result.data);
        }
      },
      error: console.error
    });
  }

  Delete() {
    if (!this.item.id) return;

    this.service.Delete(this.item.id).subscribe({
      next: (result: Result) => {
        if (result.status >= ResultStatus.Invalid) console.error(result);
        else this.router.navigate(['users']);
      },
      error: console.error
    });
  }
}
