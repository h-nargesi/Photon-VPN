import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { PlansService } from './plans.service';
import { Plan } from './plans.models';
import { ListViewComponent } from '../components/list-view.component';

@Component({
  selector: 'app-plans',
  templateUrl: './plans.component.html',
})
export class PlansComponent extends ListViewComponent implements OnInit {

  constructor(
    title: Title,
    private readonly service: PlansService) {
    super();
    title.setTitle("Plans | Photon - VPN");
  }

  ngOnInit(): void {
    this.service.List()
      .subscribe({
        next: (result: Plan[]) => this.InitDataSource(result),
        error: console.error
      });
  }
}
