import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { catchError, Observable, ObservableInput, tap } from 'rxjs';
import { BaseWebService, NotifyService, Result } from '../../components';
import { Invoice, Membership, UserPlanRequest } from './membership.model';

@Injectable({
  providedIn: 'root',
})
export class MembershipService extends BaseWebService {

  protected override readonly entity_name: string = 'membership';

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

  public Add(entity: UserPlanRequest): Observable<Result> {
    return this.http
      .post<Result>(this.module_url + 'add', entity)
      .pipe(
        tap(result => this.handleResult(result)),
        catchError<Result, ObservableInput<any>>(this.handleError.bind(this))
      );
  }

  public Delete(useid: number, datetime: Date): Observable<Result> {
    return this.http
      .post<Result>(this.module_url + 'delete', { permanentUserId: useid, date: datetime })
      .pipe(
        tap(result => this.handleResult(result)),
        catchError<Result, ObservableInput<any>>(this.handleError.bind(this))
      );
  }
}
