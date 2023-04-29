import { Component, EventEmitter, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { BaseComponent, ListViewModel, ListViewSchema, Result, ResultStatus, WidgetViewComponent } from '../../components';
import Titles from '../plans.json';
import { PlanModel } from '../plans.models';
import { PlansService } from '../plans.service';

@Component({
  selector: 'app-plan-list',
  templateUrl: './plan-list.component.html',
})
export class PlanListComponent extends BaseComponent {
  public columns_info: ListViewModel = Titles.list;
  public columns_schema: ListViewSchema = Titles.schema;
  public data_provider: Observable<PlanModel[]> | undefined;
  public reload: EventEmitter<any[]> | undefined;

  @ViewChild('widgetView') private widget_view: WidgetViewComponent | undefined;

  constructor(
    private readonly service: PlansService,
    private readonly router: Router) {
    super();
  }

  ngOnInit(): void {
    this.service.List(null).subscribe({
      next: (result: any[]) => this.widget_view?.SetDataSource(result),
      error: console.error
    });
  }

  onAddClick() {
    this.router.navigate(['plans', 'edit']);
  }

  onDeleteClick(item: PlanModel) {
    this.service.Delete(item.id).subscribe({
      next: (result: Result) => {
        if (result.status >= ResultStatus.Invalid)
          console.error(result);

        this.ngOnInit();
      },
      error: console.error
    });
  }

  onEditClick(item: PlanModel) {
    this.router.navigate(['plans', 'edit', item.id]);
  }
}
