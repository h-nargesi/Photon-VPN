import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { UsersService } from './users.service';
import { User } from './users.model';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
})
export class UsersComponent implements OnInit {
  private users: User[] | null = null;

  constructor(
    title: Title,
    private readonly service: UsersService) {
    title.setTitle("Users | Photon - VPN");
  }

  get Users(): User[] {
    return this.users != null ? this.users : [];
  }

  ngOnInit(): void {
    this.service.List()
      .subscribe({
        next: (result: User[]) => this.users = result,
        error: console.error
      });
  }
}
