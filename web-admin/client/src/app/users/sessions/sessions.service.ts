import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { BaseService } from 'src/app/base-service';
import { Session } from './sessions.model';

@Injectable({
  providedIn: 'root',
})
export class SessionsService extends BaseService {

	constructor(
		http: HttpClient,
		@Inject('API_URL') api_url: string,
		@Inject('BASE_URL') base_url: string) {
		super(http, api_url, base_url, 'api/sessions/');
	}

  public List(only_open: boolean): Observable<Session[]> {
    return this.http.post<Session[]>(this.base_url + 'list?only_open=' + only_open, { });
  }
}