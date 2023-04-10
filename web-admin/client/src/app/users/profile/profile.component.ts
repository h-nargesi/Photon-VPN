import { Component } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { AppBaseComponent } from '../../app-base-component';

@Component({
  selector: 'app-users-profile',
  templateUrl: './profile.component.html',
})
export class ProfileComponent extends AppBaseComponent {
  constructor(title: Title) {
    super("Profile", title);
  }
}
