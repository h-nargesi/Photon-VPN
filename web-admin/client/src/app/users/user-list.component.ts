import { Component } from '@angular/core';
import { EntitySchema, ListQuery } from '../components';
import Titles from './info/users.json';
import { UsersService } from './users.service';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
})
export class UserListComponent {

  title: string = "Users";
  columns_info: EntitySchema = Titles.list;
  active_count!: number;

  constructor(public readonly service: UsersService) { }

  LoadActiveCount(query: ListQuery | null) {
    this.service.ActiveCount(query).subscribe((result) => this.active_count = result);
  }
}
