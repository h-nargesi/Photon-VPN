import { HttpClient } from '@angular/common/http';
import { Inject } from '@angular/core';
import { Observable } from 'rxjs';
import { BaseService } from './base-service';
import { LGMDService } from './lgmd-service';
import { ListQuery, Result } from './list-query.model';

export abstract class EntityService<L, E> extends BaseService implements LGMDService {

  private query_string: string = '';

  constructor(
    http: HttpClient,
    @Inject('API_URL') api_url: string,
    @Inject('BASE_URL') base_url: string,
    entity_name: string) {
    super(http, api_url, base_url, `api/${entity_name}/`);
  }

  public List(filter: ListQuery | null = null): Observable<L[]> {
    if (filter == null) filter = {} as ListQuery;
    return this.http.post<L[]>(this.module_url + 'list' + this.query_string, filter);
  }

  public Count(filter: ListQuery | null = null): Observable<number> {
    if (filter == null) filter = {} as ListQuery;
    return this.http.post<number>(this.module_url + 'count' + this.query_string, filter);
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

  protected SetQueryString(name: string, value: any): EntityService<L, E> {
    this.query_string += `${this.query_string.length > 0 ? '&' : '?'}${name}=${value}`;
    return this;
  }

  protected SetRoute(value: any): EntityService<L, E> {
    this.query_string += `/${value}`;
    return this;
  }

  protected ClearQueryString(): EntityService<L, E> {
    this.query_string = '';
    return this;
  }

}
