import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { PlansService } from './plans.service';
import { Plan } from './plans.models';
import { Observable } from 'rxjs';
import { ListViewModel } from '../components/list-view/list-view.model';
import Titles from './plans.json';

@Component({
  selector: 'app-plans',
  templateUrl: './plans.component.html',
})
export class PlansComponent implements OnInit {
  public columns_info: ListViewModel = Titles.list;
  public data_provider: Observable<Plan[]> | null = null;

  constructor(
    title: Title,
    private readonly service: PlansService) {
    title.setTitle("Plans | Photon - VPN");
  }

  ngOnInit(): void {
    this.data_provider = this.service.List();
  }
}
