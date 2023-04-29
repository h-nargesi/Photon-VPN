import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent, ListViewModel, Result, ResultStatus } from '../components';
import Titles from './payments.json';
import { Payment } from './payments.model';
import { PaymentsService } from './payments.service';

@Component({
  selector: 'app-payment',
  templateUrl: './payment.component.html',
})
export class PaymentComponent extends BaseComponent {
  private sub: any;
  public columns_info: ListViewModel = Titles.list;
  public item: Payment = {} as Payment;

  constructor(
    private readonly service: PaymentsService,
    private readonly route: ActivatedRoute,
    private readonly router: Router) {
    super();
  }

  get Item(): Payment {
    return this.item;
  }

  ngOnInit() {
    this.sub = this.route.params.subscribe((params) => {
      if ('id' in params) {
        this.service.Get(+params['id']).subscribe({
          next: (result: Payment) => (this.item = result),
          error: console.error,
        });
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
        if (result.status >= ResultStatus.Invalid) console.error(result);
        else {
          console.info(result);
          if (!this.item.id) this.item.id = Number(result.data);
        }
      },
      error: console.error,
    });
  }

  Delete() {
    if (!this.item.id) return;

    this.service.Delete(this.item.id).subscribe({
      next: (result: Result) => {
        if (result.status >= ResultStatus.Invalid) console.error(result);
        else this.router.navigate(['payments']);
      },
      error: console.error,
    });
  }
}
