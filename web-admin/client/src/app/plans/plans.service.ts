import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { EntityService, ListQuery, OptionService, Result, SelectOptions } from '../components';
import { Plan, PlanModel } from './plans.models';

@Injectable({
  providedIn: 'root',
})
export class PlansService extends EntityService<PlanModel, Plan> implements OptionService {

	constructor(
		http: HttpClient,
		@Inject('API_URL') api_url: string,
		@Inject('BASE_URL') base_url: string) {
    super(http, api_url, base_url, 'plans');
	}

  public Options(filter: ListQuery | null): Observable<SelectOptions[]> {
    if (filter == null) filter = {} as ListQuery;
    return this.http.post<PlanModel[]>(this.module_url + 'list', filter);
  }
}
