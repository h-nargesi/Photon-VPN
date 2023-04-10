import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Payment } from './payments.model';

@Injectable({
  providedIn: 'root',
})
export class PaymentsService {

  constructor(
    private readonly http: HttpClient,
    @Inject('BASE_URL') private readonly baseUrl: string) {
      this.baseUrl += 'api/payments/'
    }

  public List(user_id: number | null): Observable<Payment[]> {
    if (user_id == null) {
      return this.http.get<Payment[]>(this.baseUrl + 'list');
    } else {
      return this.http.get<Payment[]>(this.baseUrl + 'list', { params: { user_id: user_id } });
    }
  }

  public Get(id: number): Observable<Payment> {
    return this.http.get<Payment>(this.baseUrl + 'get', { params: { id: id } });
  }
}