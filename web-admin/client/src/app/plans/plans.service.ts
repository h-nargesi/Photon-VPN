import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Plan } from './plans.models';
import { BaseService } from '../base-service';

@Injectable({
  providedIn: 'root',
})
export class PlansService extends BaseService {

	constructor(
		http: HttpClient,
		@Inject('API_URL') api_url: string,
		@Inject('BASE_URL') base_url: string) {
		super(http, api_url, base_url, 'api/plans/');
	}

  public List(): Observable<Plan[]> {
    return this.http.get<Plan[]>(this.base_url + 'list');
  }

  public Get(id: number): Observable<Plan> {
    return this.http.get<Plan>(this.base_url + 'get', { params: { id: id } });
  }
}
