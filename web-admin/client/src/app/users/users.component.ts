import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { UsersService } from './users.service';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
})
export class UsersComponent implements OnInit {
  constructor(
    title: Title,
    private service: UsersService) {
    title.setTitle("Users | Photon - VPN");
  }

  ngOnInit(): void {
    // this.service.Users.List();
  }
}
