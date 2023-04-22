import { Component, EventEmitter, ViewChild } from '@angular/core';
import { Observable } from 'rxjs';
import { Server } from '../servers.model';
import { ServersService } from '../servers.service';
import { ListViewModel, ListViewComponent } from '../../components'
import Titles from './servers.json';

@Component({
  selector: 'app-server-list',
  templateUrl: './server-list.component.html',
  styleUrls: ['./server-list.component.scss'],
})
export class ServerListComponent {
  public columns_info: ListViewModel = Titles.list;
  public data_provider: Observable<Server[]> | undefined;
  public reload: EventEmitter<any[]> | undefined;

  @ViewChild('listView') listView: ListViewComponent | undefined;

  constructor(
    private readonly service: ServersService) { }

  ngOnInit(): void {
    console.log('reload');
    this.service.List(null).subscribe({
      next: (result: any[]) => this.listView?.SetDataSource(result),
      error: console.error
    });
  }

  onAddClick() {
    console.log('add');
  }

  onDeleteClick() {
    console.log('delete');
  }

  onEditClick() {
    console.log('edit');
  }
}
