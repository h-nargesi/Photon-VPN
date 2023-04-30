import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { BaseService, LGMDService } from '../../components';
import { Membership } from './membership.model';

@Injectable({
	providedIn: 'root',
})
export class MembershipService extends BaseService implements LGMDService {

	constructor(
		http: HttpClient,
		@Inject('API_URL') api_url: string,
		@Inject('BASE_URL') base_url: string) {
    super(http, api_url, base_url, 'api/membership/');
	  }

	public Plans(user_id: number): Observable<Membership> {
    return this.http.get<Membership>(this.module_url + 'plans', { params: { user_id: user_id } });
	}
}
