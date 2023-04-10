import { Component } from '@angular/core';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'app-users-sessions',
  templateUrl: './sessions.component.html',
})
export class SessionsComponent {
  constructor(title: Title) {
    title.setTitle("Sessions | Photon - VPN");
  }
}
