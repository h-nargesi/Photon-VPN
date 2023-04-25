import { Component } from '@angular/core';
import { ListViewModel } from '../components';
import { PaymentsService } from './payments.service';
import Titles from './payments.json';

@Component({
  selector: 'app-payment-list',
  templateUrl: './payment-list.component.html',
})
export class PaymentListComponent {
  title: string = 'Payments';
  columns_info: ListViewModel = Titles.list;

  constructor(public readonly service: PaymentsService) { }
}
