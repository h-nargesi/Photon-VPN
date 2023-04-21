import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { Server } from '../servers.model';
import { ServersService } from '../servers.service';
import { ListViewModel } from '../../components'
import Titles from './servers.json';

@Component({
  selector: 'app-server-list',
  templateUrl: './server-list.component.html',
  styleUrls: ['./server-list.component.scss']
})
export class ServerListComponent {
  public columns_info: ListViewModel = Titles.list;
  public data_provider: Observable<Server[]> | null = null;

  constructor(
    private readonly service: ServersService) { }

  ngOnInit(): void {
    this.data_provider = this.service.List(null);
  }
}
