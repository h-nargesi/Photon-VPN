import { Component, ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent, EntitySchema, Result, ResultStatus, SelectComponent } from '../components';
import { UsersService } from '../users/users.service';
import Titles from './payments.json';
import { Payment } from './payments.model';
import { PaymentsService } from './payments.service';

@Component({
  selector: 'app-payment',
  templateUrl: './payment.component.html',
})
export class PaymentComponent extends BaseComponent {
  private sub: any;
  private item: Payment = {
    value: 0,
    trnsactionId: '',
    approved: true,
    dateTime: new Date(),
    created: new Date(),
  } as Payment;
  public columns_info: EntitySchema = Titles.list;
  @ViewChild('userSelector') private user_selector: SelectComponent | undefined;

  constructor(
    private readonly service: PaymentsService,
    private readonly route: ActivatedRoute,
    private readonly router: Router,
    public readonly users_srv: UsersService) {
    super();
  }

  get Item(): Payment {
    return this.item;
  }

  ngOnInit() {
    this.sub = this.route.params.subscribe((params) => {
      if ('id' in params) {
        this.service.Get(+params['id']).subscribe({
          next: (result: Payment) => this.item = result,
          error: console.error,
        });

      } else if ('userid' in params) {
        this.item.permanentUserId = +params['id'];
        this.LoadUsers();
      }
    });
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }

  Submit() {
    console.log(this.item);

    this.service.Modify(this.item).subscribe({
      next: (result: Result) => {
        if (result.status < ResultStatus.Info && !this.item.id)
          this.item.id = Number(result.data);
      }
    });
  }

  Delete() {
    if (!this.item.id) return;

    this.service.Delete(this.item.id).subscribe({
      next: (result: Result) => {
        if (result.status < ResultStatus.Info)
          this.router.navigate(['payments']);
      }
    });
  }

  LoadUsers() {
    this.user_selector?.Load();
  }
}
