import { EntitySchema } from './base.models';

export abstract class BaseComponent {

  protected path: string | undefined;
  protected abstract get columns_info(): EntitySchema | undefined;

  titleOf(name: string) {
    return this.columns_info && name in this.columns_info ? this.columns_info[name].title : name;
  }

  val(event: any): any {
    return event.target.value;
  }

  getCookie(name: string): any {
    let json = localStorage.getItem((this.path ?? '') + name);
    let obj = !json ? null : JSON.parse(json);
    // console.log((this.path ?? '') + name, obj);
    return obj;
  }

  setCookie(name: string, object: any) {
    let json = object ? JSON.stringify(object) : '';
    // this.cookies?.setCookie({ name: name, value: json, path: this.path ? this.path : '/' });
    localStorage.setItem((this.path ?? '') + name, json);
  }

  getDateTimeString = BaseComponent.getDateTimeString;
  getDateString = BaseComponent.getDateString;
  getTimeString = BaseComponent.getTimeString;
  getRemain = BaseComponent.getRemain;

  static getDateTimeString(date: Date | null): string {
    return date?.toLocaleString().replace('T', ' ') ?? '';
  }

  static getDateString(date: Date | null): string | undefined {
    return date?.toLocaleString().substring(0, 10);
  }

  static getTimeString(time: Date | null): string | undefined {
    return time?.toLocaleString().substring(11, 20);
  }

  static getRemain(date: Date | null, past: boolean = true, details: boolean = false): string {
    if (date == null) return '';

    date = new Date(Date.parse(date.toString()));

    let result = [];
    let diff = date.getTime() - new Date().getTime();
    let slash;

    if (diff < 0) {
      diff = -diff;
      if (past) result.push('past');
    }

    slash = Math.floor(diff / 86400000);
    if (slash > 0) {
      diff %= 86400000;
      result.push(slash + ' days');
    }

    if (slash > 0 && !details) return result.join(', ');

    slash = Math.floor(diff / 3600000);
    if (slash > 0) {
      diff %= 3600000;
      result.push(slash + ' hours');
    }

    if (slash > 0 && !details) return result.join(', ');

    slash = Math.floor(diff / 60000);
    if (slash > 0) {
      diff %= 60000;
      result.push(slash + ' minutes');
    }

    return result.join(', ');
  }
}
