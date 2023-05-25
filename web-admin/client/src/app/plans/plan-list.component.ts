import { Component, EventEmitter, ViewChild } from '@angular/core';
import { Observable } from 'rxjs';
import { BaseComponent, EntitySchema, LinkService, Result, ResultStatus, WidgetSchema, WidgetViewComponent } from '../components';
import Titles from './plans.json';
import { PlanModel } from './plans.models';
import { PlansService } from './plans.service';

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
    private readonly router: LinkService) {
    super();
  }

  ngOnInit(): void {
    this.service.List().subscribe((result: any[]) => this.widget_view?.SetDataSource(result));
  }

  onAddClick() {
    this.router.jump(['plans', 'edit']);
  }

  onDeleteClick(item: PlanModel) {
    this.service.Delete(item.id).subscribe((result: Result) => {
      if (result.status < ResultStatus.Info)
        this.ngOnInit();
    });
  }

  onEditClick(item: PlanModel) {
    this.router.jump(['plans', 'edit', item.id]);
  }
}
