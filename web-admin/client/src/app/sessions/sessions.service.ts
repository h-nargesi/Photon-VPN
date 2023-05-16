import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { EntityService, NotifyService } from '../components';
import { Session } from './sessions.model';

@Injectable({
  providedIn: 'root',
})
export class SessionsService extends EntityService<Session, Session> {

  constructor(
    http: HttpClient,
    notify_service: NotifyService,
    @Inject('API_URL') api_url: string,
    @Inject('BASE_URL') base_url: string) {
    super(http, notify_service, api_url, base_url, 'sessions');
  }

  public SetOnlyOpen(only_open: boolean): SessionsService {
    super.ClearQueryString();
    super.SetQueryString('only_open', only_open);
    return this;
  }

}
