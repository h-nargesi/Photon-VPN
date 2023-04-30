import { HttpClient } from "@angular/common/http";

export abstract class BaseService {
    protected readonly base_url: string;
    protected readonly module_url: string;

    constructor(
        protected readonly http: HttpClient,
        api_url: string,
        base_url: string,
        module_url: string) {

        // console.log('API_URL', api_url);
        // console.log('BASE_URL', base_url);
        // console.log('BASE_APP', base_app);

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

        // console.log('URL', base_url);
    }
}
