import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Payment } from './payments.model';
import { BaseService, LGMDService, ListQuery, Result } from '../components';

@Injectable({
  providedIn: 'root',
})
export class PaymentsService extends BaseService implements LGMDService {

	constructor(
		http: HttpClient,
		@Inject('API_URL') api_url: string,
		@Inject('BASE_URL') base_url: string) {
		super(http, api_url, base_url, 'api/payments/');
	}

  public List(filter: ListQuery | null): Observable<Payment[]> {
    if (filter == null) filter = {} as ListQuery;
    return this.http.post<Payment[]>(this.module_url + 'list', filter);
  }

  public Get(id: number): Observable<Payment> {
    return this.http.get<Payment>(this.module_url + 'get/' + id);
  }

  public Modify(plan: Payment): Observable<Result> {
    return this.http.post<Result>(this.module_url + 'modify', plan);
  }

  public Delete(id: number): Observable<Result> {
    return this.http.post<Result>(this.module_url + 'delete', id);
  }
}
