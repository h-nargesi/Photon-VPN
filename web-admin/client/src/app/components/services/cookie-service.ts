import { Injectable } from '@angular/core';

@Injectable({
    providedIn: 'root',
})
export class CookieService {
    private cookies: { [name: string]: string } | undefined;

    constructor() { }

    private load_cookies() {
        if (this.cookies) return;
        this.cookies = {};

        const raw_key_values = document.cookie.split(';');
        console.log('document.cookie', raw_key_values);

        for (const str_key_value of raw_key_values) {
            if (!str_key_value || str_key_value.length < 2) return;
            const key_value = str_key_value.split('=');
            this.cookies[key_value[0]] = key_value[1];
        }
    }

    public getCookie(name: string): string | undefined {
        this.load_cookies();
        if (!this.cookies) return;

        console.log('loaded.cookie', this.cookies);

        if (name in this.cookies) return this.cookies[name];
        else return undefined;
    }

    public deleteCookie(cookieName: string) {
        this.setCookie({ name: cookieName, value: null, expireDays: -1 });
    }

    /**
     * Expires default 1 day
     * If params.session is set and true expires is not added
     * If params.path is not set or value is not greater than 0 its default value will be root "/"
     * Secure flag can be activated only with https implemented
     * Examples of usage:
     * {service instance}.setCookie({name:'token',value:'abcd12345', session:true }); <- This cookie will not expire
     * {service instance}.setCookie({name:'userName',value:'John Doe', secure:true }); <- If page is not https then secure will not apply
     * {service instance}.setCookie({name:'niceCar', value:'red', expireDays:10 }); <- For all this examples if path is not provided default will be root
     */
    public setCookie(params: any) {
        if (!params.name) return;

        if (this.cookies)
            if (params.value) this.cookies[params.name] = params.value;
            else delete this.cookies[params.name];

        if (!params.value) params.value = '';

        let values = [`${params.name}=${params.value}`];

        if (params.session && params.session == true) {
            let date: Date = new Date();
            date.setTime(date.getTime() + 86400000 * (params.expireDays ? params.expireDays : 30));
            values.push(params.session = 'expires=' + date.toUTCString());
        }

        if (params.path && params.path.length > 0) values.push('path=' + params.path);
        else values.push('/');

        if (location.protocol === 'https:' && params.secure && params.secure == true)
            values.push('secure');

        console.log('setCookie', values.join(';'));

        document.cookie = values.join(';') + ';';
    }
}
