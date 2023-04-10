import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Server } from './servers.model';

@Injectable({
  providedIn: 'root',
})
export class ServersService {

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string) {
    this.baseUrl += "/api/servers";
  }

  public List(): Observable<Server[]> {
    return this.http.get<Server[]>(this.baseUrl + '/list');
  }

  public Get(id: number): Observable<Server> {
    return this.http.get<Server>(this.baseUrl + '/get', { params: { id: id } });
  }
}
