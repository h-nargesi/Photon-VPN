import { Component } from '@angular/core';
import { EntitySchema } from '../components';
import { UsersService } from './users.service';
import Titles from './users.json';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
})
export class UserListComponent {

  title: string = "Users";
  columns_info: EntitySchema = Titles.list;

  constructor(public readonly service: UsersService) { }

}
