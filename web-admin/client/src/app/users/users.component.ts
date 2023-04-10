import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { UsersService } from './users.service';
import { User } from './users.model';
import { ListViewComponent } from '../components/list-view.component';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
})
export class UsersComponent extends ListViewComponent implements OnInit {

  constructor(
    title: Title,
    private readonly service: UsersService) {
    super();
    title.setTitle("Users | Photon - VPN");
  }

  ngOnInit(): void {
    this.service.List()
      .subscribe({
        next: (result: User[]) => this.InitDataSource(result),
        error: console.error
      });
  }
}
