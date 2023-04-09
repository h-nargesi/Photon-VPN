import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Membership, User } from './users.model';
import { Payment } from './payments/payments.model';

@Injectable({
  providedIn: 'root',
})
export class UsersService {

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string) { }

  public Users = {
    http: this.http,
    baseUrl: this.baseUrl + '/api/users',

    List: function (): Observable<User[]> {
      return this.http.get<User[]>(this.baseUrl + '/list');
    },

    Get: function (id: number): Observable<User> {
      return this.http.get<User>(this.baseUrl + '/get', { params: { id: id } });
    },
  }

  public Payments = {
    http: this.http,
    baseUrl: this.baseUrl + '/api/payments',

    List: function (user_id: number | null): Observable<Payment[]> {
      if (user_id == null) {
        return this.http.get<Payment[]>(this.baseUrl + '/list');
      } else {
        return this.http.get<Payment[]>(this.baseUrl + '/list', { params: { user_id: user_id } });
      }
    },

    Get: function (id: number): Observable<Payment> {
      return this.http.get<Payment>(this.baseUrl + '/get', { params: { id: id } });
    },
  }

  public Membership = {
    http: this.http,
    baseUrl: this.baseUrl + '/api/membership',

    Plans: function (user_id: number): Observable<Membership> {
      return this.http.get<Membership>(this.baseUrl + '/plans', { params: { user_id: user_id } });
    },
  }
}