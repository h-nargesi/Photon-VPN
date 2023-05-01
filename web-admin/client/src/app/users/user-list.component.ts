import { Component } from '@angular/core';
import { BaseComponent, EntitySchema } from '../components';
import { UsersService } from './users.service';
import Titles from './info/users.json';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
})
export class UserListComponent {

  title: string = "Users";
  columns_info: EntitySchema = Titles.list;

  constructor(public readonly service: UsersService) { }

  data_projection(data: any[]): any[] {
    for (var user of data) {
      user.toDate = BaseComponent.getRemain(user.toDate);
      user.fromDate = BaseComponent.getDateString(user.fromDate);
    }

    return data;
  }
}
