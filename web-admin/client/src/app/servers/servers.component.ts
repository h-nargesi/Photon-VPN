import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { ListViewComponent } from '../components/list-view.component';
import { Server } from './servers.model';
import { ServersService } from './servers.service';

@Component({
  selector: 'app-servers',
  templateUrl: './servers.component.html',
})
export class ServersComponent extends ListViewComponent implements OnInit {

  constructor(
    title: Title,
    private readonly service: ServersService) {
    super();
    title.setTitle("Servers | Photon - VPN");
  }

  ngOnInit(): void {
    this.service.List()
      .subscribe({
        next: (result: Server[]) => this.InitDataSource(result),
        error: console.error
      });
  }
}
