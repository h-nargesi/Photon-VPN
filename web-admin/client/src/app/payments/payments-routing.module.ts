import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { PaymentListComponent } from './payment-list.component';
import { PaymentComponent } from './edit/payment.component';

const routes: Routes = [
  {
    path: '',
    data: {
      title: 'Payments',
    },
    children: [
      {
        path: '',
        component: PaymentListComponent,
        data: {
          title: 'Payment List',
        },
      },
      {
        path: 'edit',
        component: PaymentComponent,
        data: {
          title: 'Add Payment',
        },
      },
      {
        path: 'edit/:id',
        component: PaymentComponent,
        data: {
          title: 'Edit Payment',
        },
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class PaymentsRoutingModule {}
