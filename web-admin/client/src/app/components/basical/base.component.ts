import { CookieService } from '../services/coockie-service';
import { EntitySchema } from './base.models';

export abstract class BaseComponent {

    protected readonly cookies:  CookieService | undefined;
    protected abstract get columns_info(): EntitySchema | undefined;

    titleOf(name: string) {
        return this.columns_info && name in this.columns_info ? this.columns_info[name].title : name;
    }

    getDateTimeString(date: Date): string {
        return date.toLocaleString().replace('T', ' ');
    }

    getDateString(date: Date | null): string | undefined {
        return date?.toLocaleString().substring(0, 10);
    }

    getTimeString(time: Date | null): string | undefined {
        return time?.toLocaleString().substring(11, 20);
    }

    getRemain(date: Date | null, depth: number = 0): string {
        if (date == null) return '';

        date = new Date(Date.parse(date.toString()));

        let result = [];
        let diff = date.getTime() - new Date().getTime();
        let slash;

        if (diff < 0) {
            diff = -diff;
            result.push('past');
        }

        slash = Math.floor(diff / 86400000);
        if (slash > 0) {
            diff %= 86400000;
            result.push(slash + ' days');
        }

        if (depth < 1) return result.join(', ');

        slash = Math.floor(diff / 3600000);
        if (slash > 0) {
            diff %= 3600000;
            result.push(slash + ' hours');
        }

        if (depth < 2) return result.join(', ');

        slash = Math.floor(diff / 60000);
        if (slash > 0) {
            diff %= 60000;
            result.push(slash + ' minutes');
        }

        return result.join(', ');
    }

    val(event: any): any {
        return event.target.value;
    }

    getCookie(name: string): any {
        let json = this.cookies?.getCookie(name);
        if (!json) return null;
        return JSON.parse(json);
    }

    setCookie(name: string, object: any) {
        let json = object ? JSON.stringify(object) : '';
        this.cookies?.setCookie({ name: name, value: json });
    }
}