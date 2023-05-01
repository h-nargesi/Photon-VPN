import { Component, Input, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { EntitySchema } from '../../basical/base.models';
import { TableViewComponent } from '../table-view/table-view.component';
import { LGMDService } from '../../services/lgmd-service';
import { ListQuery, Result, ResultStatus } from '../../services/list-query.model';
import { BaseComponent } from '../../basical/base.component';
import { CookieService } from '../../services/cookie-service';

@Component({
  selector: 'app-table-page',
  templateUrl: './table-page.component.html',
})
export class TablePageComponent extends BaseComponent {

  @Input("small") small: boolean = true;
  @Input("title") title: string | undefined;
  @Input("columns-info") columns_info: EntitySchema | undefined;
  @Input("data-projection") data_projection: ((data: any[]) => any[]) | undefined;
  @Input("service") service: LGMDService | undefined;
  @Input('show-reload') show_reload: boolean = true;
  @Input('show-add') show_add: boolean = true;
  @Input('show-edit') show_edit: boolean = true;
  @Input('show-remove') show_remove: boolean = true;
  @Input('show-undo') show_undo: boolean = true;
  @ViewChild('tableView') private table_view: TableViewComponent | undefined;

  Query: ListQuery | null = null;

  constructor(
    private readonly router: Router,
    protected override readonly cookies: CookieService) {
    super();
    this.path = router.url;
  }

  ngOnInit(): void {
    // this.Query = this.getCookie('query');
    this.service?.List(null).subscribe({
      next: (result: any[]) => {
        this.table_view?.SetDataSource(result);
        this.setCookie('query', this.title);
        this.getCookie('query');
      },
      error: console.error
    });
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
      this.service?.Delete(element.id).subscribe({
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
    if (!this.table_view?.SelectedItems.size) return;
    const items = Array.from(this.table_view?.SelectedItems.values());
    const id = items[items.length - 1].id;
    this.router.navigate([this.title?.toLowerCase(), 'edit', id]);
  }

  onDbClick(item: any) {
    this.router.navigate([this.title?.toLowerCase(), 'edit', item.id]);
  }
}
