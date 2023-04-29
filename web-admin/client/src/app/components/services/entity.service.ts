import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { BaseService } from './base-service';
import { LGMDService } from './lgmd-service';
import { ListQuery, Result } from './list-query.model';

@Injectable({
	providedIn: 'root',
})
export class EntityService<L, E> extends BaseService implements LGMDService {

	constructor(
		http: HttpClient,
		@Inject('API_URL') api_url: string,
    @Inject('BASE_URL') base_url: string,
    entity_name: string) {
    super(http, api_url, base_url, `api/${entity_name}/`);
	  }

	public List(filter: ListQuery | null): Observable<L[]> {
		if (filter == null) filter = {} as ListQuery;
		return this.http.post<L[]>(this.module_url + 'list', filter);
	}

	public Get(id: number): Observable<E> {
		return this.http.get<E>(this.module_url + 'get/' + id);
	}

	public Modify(entity: E): Observable<Result> {
    return this.http.post<Result>(this.module_url + 'modify', entity);
	}
  
	public Delete(id: number): Observable<Result> {
	  return this.http.post<Result>(this.module_url + 'delete', id);
	}
}
