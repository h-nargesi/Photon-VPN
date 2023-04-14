import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { Observable } from 'rxjs';
import { ListViewModel } from '../components/list-view/list-view.model';
import { Server } from './servers.model';
import { ServersService } from './servers.service';
import Titles from './servers.json';

@Component({
  selector: 'app-servers',
  templateUrl: './servers.component.html',
})
export class ServersComponent implements OnInit {
  public columns_info: ListViewModel = Titles.list;
  public data_provider: Observable<Server[]> | null = null;

  constructor(
    title: Title,
    private readonly service: ServersService) {
    title.setTitle("Servers | Photon - VPN");
  }

  ngOnInit(): void {
    this.data_provider = this.service.List();
  }
}
