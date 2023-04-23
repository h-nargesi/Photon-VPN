import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { PlanModel, Plan } from './plans.models';
import { BaseService, ListQuery, Result } from '../components';

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

  public List(filter: ListQuery | null): Observable<PlanModel[]> {
    if (filter == null) filter = {} as ListQuery;
    return this.http.post<PlanModel[]>(this.base_url + 'list', filter);
  }

  public Get(id: number): Observable<Plan> {
    return this.http.get<Plan>(this.base_url + 'get/' + id);
  }

  public Modify(plan: Plan): Observable<Result> {
    return this.http.post<Result>(this.base_url + 'modify', plan);
  }

  public Delete(id: number): Observable<Result> {
    return this.http.post<Result>(this.base_url + 'delete', id);
  }
}
