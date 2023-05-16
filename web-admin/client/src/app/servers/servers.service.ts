import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { EntityService, NotifyService } from '../components';
import { Server } from './servers.model';

@Injectable({
  providedIn: 'root',
})
export class ServersService extends EntityService<Server, Server> {

  constructor(
    http: HttpClient,
    notify_service: NotifyService,
    @Inject('API_URL') api_url: string,
    @Inject('BASE_URL') base_url: string) {
    super(http, notify_service, api_url, base_url, 'servers');
  }

}
