import { Component } from '@angular/core';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'app-servers',
  //templateUrl: './servers.component.html',
  template: '<div></div>',
})
export class ServersComponent {
  constructor(title: Title) {
    title.setTitle("Servers | Photon - VPN");
  }
}
