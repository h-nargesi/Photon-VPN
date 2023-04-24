import { Component } from '@angular/core';
import { ListViewModel } from '../components';
import { UsersService } from './users.service';
import Titles from './users.json';

@Component({
  selector: 'app-user-list',
  template: '<app-table-page [title]="title" [columns-info]="columns_info" [service]="service"></app-table-page>',
})
export class UsersListComponent {

  title: string = "Users";
  columns_info: ListViewModel = Titles.list;

  constructor(public readonly service: UsersService) { }

}
