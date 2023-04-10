import { HttpClient } from "@angular/common/http";
import { Inject } from "@angular/core";

export class BaseService {
    protected readonly baseUrl: string;

    constructor(
        protected readonly http: HttpClient,
        @Inject('API_URL') apiUrl: string,
        @Inject('BASE_URL') baseUrl: string) {

        if (apiUrl == null) apiUrl = '';
        else if (!apiUrl.endsWith('/')) apiUrl += '/';

        if (baseUrl == null) baseUrl = '';
        else if (baseUrl != null && baseUrl.startsWith('/')) baseUrl = baseUrl.substring(1);

        this.baseUrl = apiUrl + baseUrl;

        if (this.baseUrl.length > 0 && !this.baseUrl.endsWith('/')) this.baseUrl += '/';
    }
}