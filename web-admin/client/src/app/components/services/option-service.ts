import { Observable } from "rxjs";
import { SelectOptions } from '../';

export interface OptionService {

  Options(): Observable<SelectOptions[]>;
}
