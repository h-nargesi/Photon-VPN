import { Component } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { User } from '../users.model';
import { UsersService } from '../users.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-users-profile',
  templateUrl: './profile.component.html',
})
export class ProfileComponent {
  private id: number | null = null;
  private profile: User | null = null;

  constructor(
    title: Title,
    private readonly service: UsersService,
    private readonly route: ActivatedRoute) {
    title.setTitle("Profile | Photon - VPN");
  }

  get Profile(): User | null {
    return this.profile;
  }

  ngOnInit(): void {
    this.id = Number(this.route.snapshot.paramMap.get('id'));
    if (!Number.isNaN(this.id)) {
      this.service.Get(this.id)
        .subscribe({
          next: (result: User) => this.profile = result,
          error: console.error
        });
    } else {
      this.id = null;
    }
  }
}
