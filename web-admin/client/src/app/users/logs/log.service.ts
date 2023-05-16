import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { EntityService, NotifyService } from '../../components';
import { UserLog } from './log.model';

@Injectable({
  providedIn: 'root',
})
export class UserLogService extends EntityService<UserLog, UserLog> {

  constructor(
    http: HttpClient,
    notify_service: NotifyService,
    @Inject('API_URL') api_url: string,
    @Inject('BASE_URL') base_url: string) {
    super(http, notify_service, api_url, base_url, 'userlogs');
  }

  public SetUserId(user_id: number): UserLogService {
    super.ClearQueryString();
    super.SetRoute(user_id);
    return this;
  }

}
