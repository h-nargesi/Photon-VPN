import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Session } from './sessions.model';
import { BaseService, LGMDService, ListQuery, Result } from '../components';

@Injectable({
  providedIn: 'root',
})
export class SessionsService extends BaseService implements LGMDService {

	constructor(
		http: HttpClient,
		@Inject('API_URL') api_url: string,
		@Inject('BASE_URL') base_url: string) {
		super(http, api_url, base_url, 'api/sessions/');
	}

  public List(filter: ListQuery | null): Observable<Session[]> {
    if (filter == null) filter = {} as ListQuery;
    return this.http.post<Session[]>(this.module_url + 'list', filter);
  }

  public Listt(only_open: boolean, filter: ListQuery | null): Observable<Session[]> {
    return this.http.post<Session[]>(this.base_url + 'list?only_open=' + only_open, filter);
  }

  public Get(id: number): Observable<Session> {
    return this.http.get<Session>(this.module_url + 'get/' + id);
  }

  public Modify(plan: Session): Observable<Result> {
    return this.http.post<Result>(this.module_url + 'modify', plan);
  }

  public Delete(id: number): Observable<Result> {
    return this.http.post<Result>(this.module_url + 'delete', id);
  }
}
