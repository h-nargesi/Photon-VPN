import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { EntityService, OptionService, SelectOptions, ListQuery } from '../components';
import { User } from './users.model';

@Injectable({
  providedIn: 'root',
})
export class UsersService extends EntityService<User, User> implements OptionService {

  constructor(
    http: HttpClient,
    @Inject('API_URL') api_url: string,
    @Inject('BASE_URL') base_url: string) {
    super(http, api_url, base_url, 'users');
  }

  public Options(filter: ListQuery | null): Observable<SelectOptions[]> {
    if (filter == null) filter = {} as ListQuery;
    return this.http.post<SelectOptions[]>(this.module_url + 'options', filter);
  }

}
