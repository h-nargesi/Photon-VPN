import { Component, EventEmitter, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { PlanModel } from '../plans.models';
import { PlansService } from '../plans.service';
import { ListViewModel, WidgetViewComponent, Result, ResultStatus, ListViewSchema } from '../../components';
import Titles from '../plans.json';

@Component({
  selector: 'app-plan-list',
  templateUrl: './plan-list.component.html',
})
export class PlanListComponent {
  public columns_info: ListViewModel = Titles.list;
  public columns_schema: ListViewSchema = Titles.schema;
  public data_provider: Observable<PlanModel[]> | undefined;
  public reload: EventEmitter<any[]> | undefined;

  @ViewChild('widgetView') private widget_view: WidgetViewComponent | undefined;

  constructor(
    private readonly service: PlansService,
    private readonly router: Router) { }

  ngOnInit(): void {
    this.service.List(null).subscribe({
      next: (result: any[]) => this.widget_view?.SetDataSource(result),
      error: console.error
    });
  }

  onAddClick() {
    this.router.navigate(['plans', 'edit']);
  }

  onDeleteClick() {
    if (!this.widget_view?.SelectedItems.size) return;
    let items = Array.from(this.widget_view?.SelectedItems.values());

    items.forEach((element) => {
      this.service.Delete(element.id).subscribe({
        next: (result: Result) => {
          if (result.status >= ResultStatus.Invalid)
            console.error(result);

          const i = items.indexOf(element, 0);
          items.splice(i, 1);
          if (items.length < 1) {
            this.ngOnInit();
          }
        },
        error: console.error
      });
    });
  }

  onEditClick() {
    if (!this.widget_view?.SelectedItems.size) return;
    const items = Array.from(this.widget_view?.SelectedItems.values());
    const id = items[items.length - 1].id;
    this.router.navigate(['plans', 'edit', id]);
  }

  onDbClick(item: any) {
    this.router.navigate(['plans', 'edit', item.id]);
  }
}
