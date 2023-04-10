import { Component } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { Payment } from './payments.model';
import { PaymentsService } from './payments.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-users-payments',
  templateUrl: './payments.component.html',
})
export class PaymentsComponent {
  private id: number | null = null;
  private payments: Payment[] | null = null;

  constructor(
    title: Title,
    private readonly service: PaymentsService,
    private readonly route: ActivatedRoute) {
    title.setTitle("Payments | Photon - VPN");
  }

  get Payments(): Payment[] | null {
    return this.payments;
  }

  ngOnInit(): void {
    this.id = Number(this.route.snapshot.paramMap.get('id'));
    if (Number.isNaN(this.id)) {
      this.id = null;
    }
    this.service.List(this.id)
      .subscribe({
        next: (result: Payment[]) => this.payments = result,
        error: console.error
      });
  }
}
