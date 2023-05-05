import { Component } from '@angular/core';
import { BaseComponent, EntitySchema } from '../components';
import Titles from './sessions.json';
import { SessionsService } from './sessions.service';

@Component({
  selector: 'app-session-list',
  templateUrl: './session-list.component.html',
})
export class SessionListComponent {
  title: string = 'Sessions';
  columns_info: EntitySchema = Titles.list;

  constructor(public readonly service: SessionsService) {}

  data_projection(data: any[]): any[] {
    for (var user of data) {
      user.acctstoptime = BaseComponent.getDateTimeString(user.acctstoptime);
      user.acctupdatetime = BaseComponent.getRemain(user.acctupdatetime, false);
      user.acctstarttime = BaseComponent.getDateTimeString(user.acctstarttime);
    }

    return data;
  }
}
