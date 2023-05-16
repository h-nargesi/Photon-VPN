import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { BaseWebService, NotifyService, Result } from '../../components';
import { Invoice, Membership } from './membership.model';

@Injectable({
  providedIn: 'root',
})
export class MembershipService extends BaseWebService {

  constructor(
    http: HttpClient,
    notify_service: NotifyService,
    @Inject('API_URL') api_url: string,
    @Inject('BASE_URL') base_url: string) {
    super(http, notify_service, api_url, base_url, 'api/membership/');
  }

  public Balance(user_id: number): Observable<Invoice[]> {
    return this.http.get<Invoice[]>(this.module_url + 'balance/' + user_id);
  }

  public Add(entity: Membership): Observable<Result> {
    return this.http.post<Result>(this.module_url + 'add', entity);
  }

  public Delete(id: number): Observable<Result> {
    return this.http.post<Result>(this.module_url + 'delete', id);
  }
}
