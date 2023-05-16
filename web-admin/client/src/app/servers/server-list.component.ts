import { Component } from '@angular/core';
import { BaseComponent, EntitySchema } from '../components';
import Titles from './servers.json';
import { ServersService } from './servers.service';

@Component({
  selector: 'app-server-list',
  templateUrl: './server-list.component.html',
})
export class ServerListComponent extends BaseComponent {

  title: string = "Servers";
  columns_info: EntitySchema = Titles.list;

  constructor(public readonly service: ServersService) {
    super();
  }

}
