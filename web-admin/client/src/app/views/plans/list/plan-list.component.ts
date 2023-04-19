import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { ListViewModel } from '../../../components/list-view/list-view.model';
import { Plan } from '../plans.models';
import Titles from './plans.json';

@Component({
  selector: 'app-plan-list',
  templateUrl: './plan-list.component.html',
  styleUrls: ['./plan-list.component.scss']
})
export class PlanListComponent {
  public columns_info: ListViewModel = Titles.list;
  public data_provider: Observable<Plan[]> | null = null;

  constructor(
    private readonly service: PlansService) { }

  ngOnInit(): void {
    this.data_provider = this.service.List(null);
  }
}
