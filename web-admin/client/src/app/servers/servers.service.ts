import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Server } from './servers.model';
import { BaseService, ListQuery } from '../components';

@Injectable({
  providedIn: 'root',
})
export class ServersService extends BaseService {

  constructor(
    http: HttpClient,
    @Inject('API_URL') api_url: string,
    @Inject('BASE_URL') base_url: string) {
    super(http, api_url, base_url, 'api/servers/');
  }

  public List(filter: ListQuery | null): Observable<Server[]> {
    if (filter == null) filter = {} as ListQuery;
    return this.http.post<Server[]>(this.base_url + 'list', filter);
  }

  public Get(id: number): Observable<Server> {
    return this.http.get<Server>(this.base_url + 'get/' + id);
  }

  public Delete(id: number): Observable<Object> {
    return this.http.post(this.base_url + 'delete', id);
  }
}
