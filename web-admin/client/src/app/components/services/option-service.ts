import { Observable } from "rxjs";
import { SelectOptions } from '../';
import { ListQuery } from './list-query.model';

export interface OptionService  {

    Options(filter: ListQuery | null): Observable<SelectOptions[]>;
}
