import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
// import { ProfileModel, Profile } from './profiles.models';
import { BaseService, LGMDService, ListQuery, OptionService, Result, SelectOptions } from '../components';

@Injectable({
  providedIn: 'root',
})
export class ProfilesService extends BaseService implements OptionService {

	constructor(
		http: HttpClient,
		@Inject('API_URL') api_url: string,
		@Inject('BASE_URL') base_url: string) {
		super(http, api_url, base_url, 'api/profiles/');
	}

  // public List(filter: ListQuery | null): Observable<ProfileModel[]> {
  //   if (filter == null) filter = {} as ListQuery;
  //   return this.http.post<ProfileModel[]>(this.module_url + 'list', filter);
  // }

  public Options(filter: ListQuery | null): Observable<SelectOptions[]> {
    if (filter == null) filter = {} as ListQuery;
    return this.http.post<SelectOptions[]>(this.module_url + 'options', filter);
  }

  // public Get(id: number): Observable<Profile> {
  //   return this.http.get<Profile>(this.module_url + 'get/' + id);
  // }

  // public Modify(profile: Profile): Observable<Result> {
  //   return this.http.post<Result>(this.module_url + 'modify', profile);
  // }

  // public Delete(id: number): Observable<Result> {
  //   return this.http.post<Result>(this.module_url + 'delete', id);
  // }
}
