import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { BaseService, LGMDService, ListQuery, OptionService, Result, SelectOptions } from '../components';
import { Plan, PlanModel } from './plans.models';

@Injectable({
  providedIn: 'root',
})
export class PlansService extends BaseService implements LGMDService, OptionService {

	constructor(
		http: HttpClient,
		@Inject('API_URL') api_url: string,
		@Inject('BASE_URL') base_url: string) {
		super(http, api_url, base_url, 'api/plans/');
	}

  public List(filter: ListQuery | null): Observable<PlanModel[]> {
    if (filter == null) filter = {} as ListQuery;
    return this.http.post<PlanModel[]>(this.module_url + 'list', filter);
  }

  public Options(filter: ListQuery | null): Observable<SelectOptions[]> {
    if (filter == null) filter = {} as ListQuery;
    return this.http.post<PlanModel[]>(this.module_url + 'list', filter);
  }

  public Get(id: number): Observable<Plan> {
    return this.http.get<Plan>(this.module_url + 'get/' + id);
  }

  public Modify(plan: Plan): Observable<Result> {
    return this.http.post<Result>(this.module_url + 'modify', plan);
  }

  public Delete(id: number): Observable<Result> {
    return this.http.post<Result>(this.module_url + 'delete', id);
  }
}
