import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Plan } from './plans.models';

@Injectable({
  providedIn: 'root',
})
export class PlansService {

  constructor(
    private readonly http: HttpClient,
    @Inject('BASE_URL') private readonly baseUrl: string) {
    this.baseUrl += "api/plans/";
  }

  public List(): Observable<Plan[]> {
    return this.http.get<Plan[]>(this.baseUrl + 'list');
  }

  public Get(id: number): Observable<Plan> {
    return this.http.get<Plan>(this.baseUrl + 'get', { params: { id: id } });
  }
}
