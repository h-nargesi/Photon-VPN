import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Membership, User } from './users.model';
import { BaseService } from '../base-service';

@Injectable({
	providedIn: 'root',
})
export class UsersService extends BaseService {

	constructor(
		http: HttpClient,
		@Inject('API_URL') apiUrl: string,
		@Inject('BASE_URL') baseUrl: string) {
		super(http, apiUrl, baseUrl);
	}

	public List(): Observable<User[]> {
		return this.http.get<User[]>(this.baseUrl + 'api/users/list');
	}

	public Get(id: number): Observable<User> {
		return this.http.get<User>(this.baseUrl + 'api/users/get', { params: { id: id } });
	}

	public Plans(user_id: number): Observable<Membership> {
		return this.http.get<Membership>(this.baseUrl + 'api/membership/plans', { params: { user_id: user_id } });
	}
}