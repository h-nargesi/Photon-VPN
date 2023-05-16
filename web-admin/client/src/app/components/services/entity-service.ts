import { HttpClient } from '@angular/common/http';
import { catchError, Observable, ObservableInput, tap } from 'rxjs';
import { NotifyService } from '../basical/notify/notify.service';
import { BaseWebService } from './base-web-service';
import { LGMDService } from './lgmd-service';
import { ListQuery, Result } from './list-query.model';

export abstract class EntityService<L, E> extends BaseWebService implements LGMDService {

  private query_string: string = '';

  constructor(
    http: HttpClient,
    notify_service: NotifyService,
    api_url: string,
    base_url: string,
    protected override entity_name: string) {

    super(http, notify_service, api_url, base_url, `api/${entity_name}/`);
  }

  public List(filter: ListQuery | null = null): Observable<L[]> {
    if (filter == null) filter = {} as ListQuery;
    return this.http
      .post<L[]>(this.module_url + 'list' + this.query_string, filter)
      .pipe<L[]>(catchError<L[], ObservableInput<any>>(this.handleError));
  }

  public Count(filter: ListQuery | null = null): Observable<number> {
    if (filter == null) filter = {} as ListQuery;
    return this.http
      .post<number>(this.module_url + 'count' + this.query_string, filter)
      .pipe<number>(catchError<number, ObservableInput<any>>(this.handleError));
  }

  public Get(id: number): Observable<E> {
    return this.http
      .get<E>(this.module_url + 'get/' + id)
      .pipe<E>(catchError<E, ObservableInput<any>>(this.handleError));
  }

  public Modify(entity: E): Observable<Result> {
    return this.http
      .post<Result>(this.module_url + 'modify', entity)
      .pipe(
        tap(result => this.handleResult(result)),
        catchError<Result, ObservableInput<any>>(this.handleError)
      );
  }

  public Delete(id: number): Observable<Result> {
    return this.http
      .post<Result>(this.module_url + 'delete', id)
      .pipe(
        tap(result => this.handleResult(result)),
        catchError<Result, ObservableInput<any>>(this.handleError)
      );
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
