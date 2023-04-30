import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { EntityService } from '../components';
import { Session } from './sessions.model';

@Injectable({
  providedIn: 'root',
})
export class SessionsService extends EntityService<Session, Session> {

	constructor(
		http: HttpClient,
		@Inject('API_URL') api_url: string,
		@Inject('BASE_URL') base_url: string) {
    super(http, api_url, base_url, 'sessions');
	}

}
