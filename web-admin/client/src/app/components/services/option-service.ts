import { Observable } from "rxjs";
import { ListQuery } from './list-query.model';
import { SelectOptions } from '../'

export interface OptionService  {

    Options(filter: ListQuery | null): Observable<SelectOptions[]>;
}
