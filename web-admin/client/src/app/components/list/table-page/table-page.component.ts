import { Component, EventEmitter, Input, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { ListViewModel } from '../list-view.model';
import { TableViewComponent } from '../table-view/table-view.component';
import { LGMDService } from '../../services/lgmd-service';
import { Result, ResultStatus } from '../../services/list-query.model';

@Component({
  selector: 'app-table-page',
  templateUrl: './table-page.component.html',
})
export class TablePageComponent {

  @Input("title") title : string | undefined;
  @Input("columns-info") columns_info: ListViewModel | undefined;
  @Input("service") service : LGMDService | undefined;
  @ViewChild('tableView') private table_view: TableViewComponent | undefined;

  constructor(private readonly router: Router) { }

  ngOnInit(): void {
    this.service?.List(null).subscribe({
      next: (result: any[]) => this.table_view?.SetDataSource(result),
      error: console.error
    });
  }

  onAddClick() {
    this.router.navigate([this.title?.toLowerCase(), 'edit']);
  }

  onDeleteClick() {
    if (!this.table_view?.SelectedItems.size) return;
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
