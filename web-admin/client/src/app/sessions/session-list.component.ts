import { Component } from '@angular/core';
import { ListViewModel } from '../components';
import Titles from './sessions.json';
import { SessionsService } from './sessions.service';

@Component({
  selector: 'app-session-list',
  templateUrl: './session-list.component.html',
})
export class SessionListComponent {
  title: string = 'Sessions';
  columns_info: ListViewModel = Titles.list;

  constructor(public readonly service: SessionsService) {}
}
