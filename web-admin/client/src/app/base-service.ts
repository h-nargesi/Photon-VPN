import { HttpClient } from "@angular/common/http";
import { Inject } from "@angular/core";

export class BaseService {
    protected readonly base_url: string;

    constructor(
        protected readonly http: HttpClient,
        @Inject('API_URL') api_url: string,
        @Inject('BASE_URL') base_url: string,
        base_app: string) {

        if (api_url == null) api_url = '';
        else if (api_url.length > 0 && !api_url.endsWith('/')) api_url += '/';

        if (base_url == null) base_url = '';
        else if (base_url.length > 0) {
            if (base_url.startsWith('/')) base_url = base_url.substring(1);
            if (!base_url.endsWith('/')) base_url += '/';
        }

        if (base_app == null) base_app = '';
        else if (base_app.length > 0)  {
            if (base_app.startsWith('/')) base_app = base_app.substring(1);
            if (!base_app.endsWith('/')) base_app += '/';
        }

        this.base_url = api_url + base_url + base_app;
    }
}