import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { ListViewModel } from '../components/list-view/list-view.model';
import { UsersService } from './users.service';
import { Observable } from 'rxjs';
import { User } from './users.model';
import Titles from './users.json';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
})
export class UsersComponent implements OnInit {
  public readonly columns_info: ListViewModel = Titles.list;
  public data_provider: Observable<User[]> | null = null;
  private selected_records: Set<any> = new Set<any>();

  constructor(
    title: Title,
    private readonly service: UsersService) {
    title.setTitle("Users | Photon - VPN");
  }

  ngOnInit(): void {
    this.data_provider = this.service.List();
  }

  updated(v: any) {
    console.log(v);
  }
}
