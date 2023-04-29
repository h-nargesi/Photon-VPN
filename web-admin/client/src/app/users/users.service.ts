import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { EntityService } from '../components';
import { User } from './users.model';

@Injectable({
	providedIn: 'root',
})
export class UsersService extends EntityService<User, User> {

	constructor(
		http: HttpClient,
		@Inject('API_URL') api_url: string,
		@Inject('BASE_URL') base_url: string) {
    super(http, api_url, base_url, 'users');
	  }

}
