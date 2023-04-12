import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Server } from './servers.model';
import { BaseService } from '../components/services/base-service';

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

  public List(): Observable<Server[]> {
    return this.http.post<Server[]>(this.base_url + 'list', { });
  }

  public Get(id: number): Observable<Server> {
    return this.http.get<Server>(this.base_url + 'get', { params: { id: id } });
  }
}
