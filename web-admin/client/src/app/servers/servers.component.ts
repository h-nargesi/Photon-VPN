import { Component } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { Server } from './servers.model';
import { ServersService } from './servers.service';

@Component({
  selector: 'app-servers',
  //templateUrl: './servers.component.html',
  template: '<div></div>',
})
export class ServersComponent {
  private servers: Server[] | null = null;

  constructor(
    title: Title,
    private readonly service: ServersService) {
    title.setTitle("Servers | Photon - VPN");
  }

  get Servers(): Server[] | null {
    return this.servers;
  }

  ngOnInit(): void {
    this.service.List()
      .subscribe({
        next: (result: Server[]) => this.servers = result,
        error: console.error
      });
  }
}
