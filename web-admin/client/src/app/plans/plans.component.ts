import { Component } from '@angular/core';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'app-plans',
  templateUrl: './plans.component.html',
})
export class PlansComponent {
  constructor(title: Title) {
    title.setTitle("Plans | Photon - VPN");
  }
}
