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

  public Options(): Observable<SelectOptions[]> {
    return this.http
      .get<SelectOptions[]>(this.module_url + 'options')
      .pipe<SelectOptions[]>(catchError<SelectOptions[], ObservableInput<any>>(this.handleError.bind(this)));
  }

}
