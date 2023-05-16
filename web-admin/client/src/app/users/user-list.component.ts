import { Component } from '@angular/core';
import { EntitySchema } from '../components';
import Titles from './info/users.json';
import { UsersService } from './users.service';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
})
export class UserListComponent {

  title: string = "Users";
  columns_info: EntitySchema = Titles.list;

  constructor(public readonly service: UsersService) { }
}
