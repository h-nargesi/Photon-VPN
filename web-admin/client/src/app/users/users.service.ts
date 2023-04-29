import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { BaseService, LGMDService, ListQuery, Result } from '../components';
import { User } from './users.model';

@Injectable({
	providedIn: 'root',
})
export class UsersService extends BaseService implements LGMDService {

	constructor(
		http: HttpClient,
		@Inject('API_URL') api_url: string,
		@Inject('BASE_URL') base_url: string) {
		super(http, api_url, base_url, 'api/users/');
	  }

	public List(filter: ListQuery | null): Observable<User[]> {
		if (filter == null) filter = {} as ListQuery;
		return this.http.post<User[]>(this.module_url + 'list', filter);
	}

	public Get(id: number): Observable<User> {
		return this.http.get<User>(this.module_url + 'get/' + id);
	}

	public Modify(server: User): Observable<Result> {
	  return this.http.post<Result>(this.module_url + 'modify', server);
	}
  
	public Delete(id: number): Observable<Result> {
	  return this.http.post<Result>(this.module_url + 'delete', id);
	}
}
