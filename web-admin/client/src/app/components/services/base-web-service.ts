import { HttpClient, HttpErrorResponse } from "@angular/common/http";
import { throwError } from "rxjs";
import { NotifyService } from '../basical/notify/notify.service';
import { Result, ResultStatus } from "./list-query.model";

export abstract class BaseWebService {
  protected readonly base_url: string;
  protected readonly module_url: string;
  protected readonly entity_name!: string;

  constructor(
    protected readonly http: HttpClient,
    public readonly notify_service: NotifyService,
    api_url: string,
    base_url: string,
    module_url: string) {

    if (api_url == null) api_url = '';
    else if (api_url.length > 0 && !api_url.endsWith('/')) api_url += '/';

    if (base_url == null) base_url = '';
    else if (base_url.length > 0) {
      if (base_url.startsWith('/')) base_url = base_url.substring(1);
      if (!base_url.endsWith('/')) base_url += '/';
    }

    if (module_url == null) module_url = '';
    else if (module_url.length > 0) {
      if (module_url.startsWith('/')) module_url = module_url.substring(1);
      if (!module_url.endsWith('/')) module_url += '/';
    }

    this.base_url = api_url + base_url;
    this.module_url = this.base_url + module_url;
  }

  protected handleResult(result: Result) {
    const entity_name = this.entity_name ?? 'entity';
    if (!result.message)
      result.message = `The ${entity_name.substring(0, entity_name.length - 1)} successfully modified.`;

    let color;
    if (result.status >= ResultStatus.Error) color = 'dark';
    else if (result.status >= ResultStatus.Invalid) color = 'dark';
    else if (result.status >= ResultStatus.Info) color = 'info';
    else if (result.status >= ResultStatus.Success) color = 'success';
    else color = 'secondary';

    this.notify_service.notify({
      delay: 5000,
      color: color,
      title: entity_name,
      description: result.message,
    });
  }

  protected handleError(error: HttpErrorResponse) {
    const entity_name = this.entity_name ?? 'entity';

    this.notify_service?.notify({
      delay: 10000,
      color: "warning",
      title: entity_name,
      description: 'Something bad happened; please try again later.',
    });

    return throwError(() => error);
  }
}
