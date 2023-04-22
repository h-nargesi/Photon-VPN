import { Component, EventEmitter, ViewChild } from '@angular/core';
import { Observable } from 'rxjs';
import { Server } from '../servers.model';
import { ServersService } from '../servers.service';
import { ListViewModel, ListViewComponent } from '../../components'
import Titles from '../servers.json';
import { Router } from '@angular/router';

@Component({
  selector: 'app-server-list',
  templateUrl: './server-list.component.html',
})
export class ServerListComponent {

  public columns_info: ListViewModel = Titles.list;
  public data_provider: Observable<Server[]> | undefined;
  public reload: EventEmitter<any[]> | undefined;

  @ViewChild('listView') listView: ListViewComponent | undefined;

  constructor(
    private readonly service: ServersService,
    private readonly router: Router) { }

  ngOnInit(): void {
    this.service.List(null).subscribe({
      next: (result: any[]) => this.listView?.SetDataSource(result),
      error: console.error
    });
  }

  onAddClick() {
    this.router.navigate(['servers', 'edit']);
  }

  onDeleteClick() {
    if (!this.listView?.SelectedItems.size) return;
    let items = Array.from(this.listView?.SelectedItems.values());
    
    items.forEach((element, index) => {
      this.service.Delete(element.id).subscribe({
        next: () => {
          delete items[index]
          if (items.length < 1) {
            this.ngOnInit();
          }
        },
        error: console.error
      });
    });
  }

  onEditClick() {
    if (!this.listView?.SelectedItems.size) return;
    const items = Array.from(this.listView?.SelectedItems.values());
    const id = items[items.length - 1].id;
    this.router.navigate(['servers', 'edit', id]);
  }
}
