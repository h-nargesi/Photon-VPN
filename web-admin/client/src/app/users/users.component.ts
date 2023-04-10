import { Component } from '@angular/core';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
})
export class UsersComponent {
  constructor(title: Title) {
    title.setTitle("Users | Photon - VPN");
  }
}
