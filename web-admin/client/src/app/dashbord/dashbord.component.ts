import { Component } from '@angular/core';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'app-dashbord',
  templateUrl: './dashbord.component.html',
})
export class DashbordComponent {
  constructor(title: Title) {
    title.setTitle("Dashbord | Photon - VPN");
  }
}
