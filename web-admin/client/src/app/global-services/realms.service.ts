import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { BaseService, ListQuery, OptionService, SelectOptions } from '../components';

@Injectable({
  providedIn: 'root',
})
export class RealmsService extends BaseService implements OptionService {

	constructor(
		http: HttpClient,
		@Inject('API_URL') api_url: string,
		@Inject('BASE_URL') base_url: string) {
		super(http, api_url, base_url, 'api/realms/');
	}

  public Options(filter: ListQuery | null): Observable<SelectOptions[]> {
    if (filter == null) filter = {} as ListQuery;
    return this.http.post<SelectOptions[]>(this.module_url + 'options', filter);
  }
}
