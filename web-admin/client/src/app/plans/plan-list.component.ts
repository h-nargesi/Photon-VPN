import { Component, EventEmitter, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { PlanModel } from './plans.models';
import { PlansService } from './plans.service';
import { EntitySchema, WidgetViewComponent, Result, ResultStatus, WidgetSchema, BaseComponent } from '../components';
import Titles from './plans.json';

@Component({
  selector: 'app-plan-list',
  templateUrl: './plan-list.component.html',
})
export class PlanListComponent extends BaseComponent {
  public columns_info: EntitySchema = Titles.list;
  public columns_schema: WidgetSchema = Titles.schema;
  public data_provider: Observable<PlanModel[]> | undefined;
  public reload: EventEmitter<any[]> | undefined;

  @ViewChild('widgetView') private widget_view: WidgetViewComponent | undefined;

  constructor(
    private readonly service: PlansService,
    private readonly router: Router) {
    super();
  }

  ngOnInit(): void {
    this.service.List().subscribe((result: any[]) => this.widget_view?.SetDataSource(result));
  }

  onAddClick() {
    this.router.navigate(['plans', 'edit']);
  }

  onDeleteClick(item: PlanModel) {
    this.service.Delete(item.id).subscribe((result: Result) => {
      if (result.status >= ResultStatus.Invalid)
        console.error(result);

      this.ngOnInit();
    });
  }

  onEditClick(item: PlanModel) {
    this.router.navigate(['plans', 'edit', item.id]);
  }
}
