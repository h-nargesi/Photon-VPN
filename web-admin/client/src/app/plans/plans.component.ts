import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { PlansService } from './plans.service';
import { Plan } from './plans.models';

@Component({
  selector: 'app-plans',
  templateUrl: './plans.component.html',
})
export class PlansComponent implements OnInit {
  private plans: Plan[] | null = null;

  constructor(
    title: Title,
    private readonly service: PlansService) {
    title.setTitle("Plans | Photon - VPN");
  }

  get Plans(): Plan[] | null {
    return this.plans;
  }

  ngOnInit(): void {
    this.service.List()
      .subscribe({
        next: (result: Plan[]) => this.plans = result,
        error: console.error
      });
  }
}
