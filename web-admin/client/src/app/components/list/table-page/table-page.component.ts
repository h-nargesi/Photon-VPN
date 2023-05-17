import { Component, EventEmitter, Input, Output, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '../../basical/base.component';
import { EntitySchema } from '../../basical/base.models';
import { LGMDService } from '../../services/lgmd-service';
import { ListQuery, Result, ResultStatus } from '../../services/list-query.model';
import { TableViewComponent } from '../table-view/table-view.component';

@Component({
  selector: 'app-table-page',
  templateUrl: './table-page.component.html',
})
export class TablePageComponent extends BaseComponent {

  @Input("filter") filter: boolean = true;
  @Input("small") small: boolean = true;
  @Input("title") title!: string;
  @Input("columns-info") columns_info!: EntitySchema;
  @Input("data-projection") data_projection!: ((data: any[]) => any[]);
  @Input("service") service!: LGMDService;
  @Input('show-reload') show_reload: boolean = true;
  @Input('show-add') show_add: boolean = true;
  @Input('show-edit') show_edit: boolean = true;
  @Input('show-remove') show_remove: boolean = true;
  @Input('show-undo') show_undo: boolean = true;

  @Output('reloading') reloading = new EventEmitter<any>();

  @ViewChild('tableView') private table_view!: TableViewComponent;

  constructor(private readonly router: Router) {
    super();
  }

  get Query(): ListQuery | null {
    return this.table_view?.Query;
  }

  onReload() {
    this.table_view?.Relaod();
  }

  onAddClick() {
    this.router.navigate([this.title?.toLowerCase(), 'edit']);
  }

  onUndoClick() {
    this.table_view?.ClearSelected();
  }

  onDeleteClick() {
    if (!this.table_view?.SelectedItems.size) {
      console.error('No item has been selected.');
      return;
    }

    let items = Array.from(this.table_view?.SelectedItems.values());

    items.forEach((element) => {
      this.service?.Delete(element.id).subscribe((result: Result) => {
        if (result.status >= ResultStatus.Invalid)
          console.error(result);

        const i = items.indexOf(element, 0);
        items.splice(i, 1);
        if (items.length < 1) {
          this.table_view?.Relaod();
        }
      });
    });
  }

  onEditClick() {
    if (!this.table_view?.SelectedItems.size) return;
    const items = Array.from(this.table_view?.SelectedItems.values());
    const id = items[items.length - 1].id;
    this.router.navigate([this.title?.toLowerCase(), 'edit', id]);
  }

  onDbClick(item: any) {
    this.router.navigate([this.title?.toLowerCase(), 'edit', item.id]);
  }
}
