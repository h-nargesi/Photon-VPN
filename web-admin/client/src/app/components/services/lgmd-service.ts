import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { BaseService } from './base-service';
import { ListQuery, Result } from './list-query.model';

export abstract class LGMDService extends BaseService {

    constructor(
        http: HttpClient,
        api_url: string,
        base_url: string,
        module_url: string) {
        super(http, api_url, base_url, module_url);
    }

    abstract List(filter: ListQuery | null): Observable<any[]>;

    abstract Get(id: number): Observable<any>;

    abstract Modify(server: any): Observable<Result>;

    abstract Delete(id: number): Observable<Result>;
}