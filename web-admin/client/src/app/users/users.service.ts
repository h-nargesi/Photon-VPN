import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { catchError, Observable, ObservableInput } from 'rxjs';
import { EntityService, ListQuery, NotifyService, OptionService, SelectOptions } from '../components';
import { User } from './info/users.model';

@Injectable({
  providedIn: 'root',
})
export class UsersService extends EntityService<User, User> implements OptionService {

  constructor(
    http: HttpClient,
    notify_service: NotifyService,
    @Inject('API_URL') api_url: string,
    @Inject('BASE_URL') base_url: string) {
    super(http, notify_service, api_url, base_url, 'users');
  }

  public Options(filter: ListQuery | null): Observable<SelectOptions[]> {
    if (filter == null) filter = {} as ListQuery;
    return this.http
      .post<SelectOptions[]>(this.module_url + 'options', filter)
      .pipe<SelectOptions[]>(catchError<SelectOptions[], ObservableInput<any>>(this.handleError.bind(this)));
  }

  public ActiveCount(filter: ListQuery | null): Observable<number> {
    if (filter == null) filter = {} as ListQuery;
    return this.http
      .post<number>(this.module_url + 'activecount', filter)
      .pipe<number>(catchError<number, ObservableInput<any>>(this.handleError.bind(this)));
  }

}
