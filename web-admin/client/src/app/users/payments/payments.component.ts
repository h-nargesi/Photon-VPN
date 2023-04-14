import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { Payment } from './payments.model';
import { PaymentsService } from './payments.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-users-payments',
  templateUrl: './payments.component.html',
})
export class PaymentsComponent implements OnInit {
  private user_id: number = 0;

  constructor(
    title: Title,
    private readonly service: PaymentsService,
    private readonly route: ActivatedRoute) {
    title.setTitle("Payments | Photon - VPN");
  }

  ngOnInit(): void {
    this.user_id = Number(this.route.snapshot.paramMap.get('user_id'));
    if (Number.isNaN(this.user_id)) {
      this.user_id = 0;
    }
    this.service.List(this.user_id);
  }
}
