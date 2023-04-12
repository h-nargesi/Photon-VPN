import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Payment } from './payments.model';
import { BaseService } from 'src/app/components/services/base-service';

@Injectable({
  providedIn: 'root',
})
export class PaymentsService extends BaseService {

	constructor(
		http: HttpClient,
		@Inject('API_URL') api_url: string,
		@Inject('BASE_URL') base_url: string) {
		super(http, api_url, base_url, 'api/payments/');
	}

  public List(user_id: number): Observable<Payment[]> {
    if (user_id < 1) {
      return this.http.get<Payment[]>(this.base_url + 'list');
    } else {
      return this.http.get<Payment[]>(this.base_url + 'list', { params: { user_id: user_id } });
    }
  }

  public Get(id: number): Observable<Payment> {
    return this.http.get<Payment>(this.base_url + 'get', { params: { id: id } });
  }
}