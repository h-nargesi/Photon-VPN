import { Component } from '@angular/core';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'app-users-payments',
  templateUrl: './payments.component.html',
})
export class PaymentsComponent {
  constructor(title: Title) {
    title.setTitle("Payments | Photon - VPN");
  }
}
