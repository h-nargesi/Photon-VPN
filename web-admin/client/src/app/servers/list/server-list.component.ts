import { Component, EventEmitter, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { Server } from '../servers.model';
import { ServersService } from '../servers.service';
import { ListViewModel, TableViewComponent, Result, ResultStatus } from '../../components';
import Titles from '../servers.json';

@Component({
  selector: 'app-server-list',
  templateUrl: './server-list.component.html',
})
export class ServerListComponent {

  public columns_info: ListViewModel = Titles.list;
  public data_provider: Observable<Server[]> | undefined;
  public reload: EventEmitter<any[]> | undefined;

  @ViewChild('tableView') private table_view: TableViewComponent | undefined;

  constructor(
    private readonly service: ServersService,
    private readonly router: Router) { }

  ngOnInit(): void {
    this.service.List(null).subscribe({
      next: (result: any[]) => this.table_view?.SetDataSource(result),
      error: console.error
    });
  }

  onAddClick() {
    this.router.navigate(['servers', 'edit']);
  }

  onDeleteClick() {
    if (!this.table_view?.SelectedItems.size) return;
    let items = Array.from(this.table_view?.SelectedItems.values());

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
    if (!this.table_view?.SelectedItems.size) return;
    const items = Array.from(this.table_view?.SelectedItems.values());
    const id = items[items.length - 1].id;
    this.router.navigate(['servers', 'edit', id]);
  }

  onDbClick(item: any) {
    this.router.navigate(['servers', 'edit', item.id]);
  }
}
