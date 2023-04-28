import { Component } from '@angular/core';
import { EntitySchema } from '../components';
import { ServersService } from './servers.service';
import Titles from './servers.json';

@Component({
  selector: 'app-server-list',
  templateUrl: './server-list.component.html',
})
export class ServerListComponent {

  title: string = "Servers";
  columns_info: EntitySchema = Titles.list;

  constructor(public readonly service: ServersService) { }

}
