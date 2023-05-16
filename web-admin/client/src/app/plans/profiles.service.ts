import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { catchError, Observable, ObservableInput } from 'rxjs';
import { BaseWebService, ListQuery, NotifyService, OptionService, SelectOptions } from '../components';

@Injectable({
  providedIn: 'root',
})
export class ProfilesService extends BaseWebService implements OptionService {

  constructor(
    http: HttpClient,
    notify_service: NotifyService,
    @Inject('API_URL') api_url: string,
    @Inject('BASE_URL') base_url: string) {
    super(http, notify_service, api_url, base_url, 'api/profiles/');
  }

  public Options(filter: ListQuery | null): Observable<SelectOptions[]> {
    if (filter == null) filter = {} as ListQuery;
    return this.http
      .post<SelectOptions[]>(this.module_url + 'options', filter)
      .pipe<SelectOptions[]>(catchError<SelectOptions[], ObservableInput<any>>(this.handleError));
  }

}
