import { Component } from '@angular/core';
import { EntitySchema } from '../components';
import { SessionsService } from './sessions.service';
import Titles from './sessions.json';

@Component({
  selector: 'app-session-list',
  templateUrl: './session-list.component.html',
})
export class SessionListComponent {
  title: string = 'Sessions';
  columns_info: EntitySchema = Titles.list;

  constructor(public readonly service: SessionsService) {}
}
