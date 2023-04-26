import { Observable } from "rxjs";
import { ListQuery, Result } from './list-query.model';

export interface LGMDService {

    List(filter: ListQuery | null): Observable<any[]>;

    Get(id: number): Observable<any>;

    Modify(server: any): Observable<Result>;

    Delete(id: number): Observable<Result>;
}
