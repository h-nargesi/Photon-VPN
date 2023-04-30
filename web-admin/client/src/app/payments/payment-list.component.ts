import { Component } from '@angular/core';
import { EntitySchema } from '../components';
import Titles from './payments.json';
import { PaymentsService } from './payments.service';

@Component({
  selector: 'app-payment-list',
  templateUrl: './payment-list.component.html',
})
export class PaymentListComponent {
  title: string = 'Payments';
  columns_info: EntitySchema = Titles.list;

  constructor(public readonly service: PaymentsService) { }
}
