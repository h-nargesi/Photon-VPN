import { ThisReceiver } from '@angular/compiler';
import { EntitySchema, UIColors } from './base.models';

export abstract class BaseComponent {

  protected path!: string;
  protected abstract get columns_info(): EntitySchema | undefined;

  Colors = [
    { title: UIColors[UIColors.secondary], id: UIColors.secondary },
    { title: UIColors[UIColors.primary], id: UIColors.primary },
    { title: UIColors[UIColors.danger], id: UIColors.danger },
    { title: UIColors[UIColors.dark], id: UIColors.dark },
    { title: UIColors[UIColors.info], id: UIColors.info },
    { title: UIColors[UIColors.light], id: UIColors.light },
    { title: UIColors[UIColors.success], id: UIColors.success },
    { title: UIColors[UIColors.warning], id: UIColors.warning },
  ];

  titleOf(name: string, columns_info: EntitySchema | undefined = undefined) {
    if (!columns_info) columns_info = this.columns_info;
    return columns_info && name in columns_info ? columns_info[name].title : name;
  }

  val(event: any): any {
    return event.target.value;
  }

  selector(event: any) {
    var target = event.target;
    return target[target.selectedIndex].title;
  }

  num(event: any): number {
    return +event.target.value;
  }

  checkVal(event: any): boolean {
    return event.target.checked;
  }

  isObject(value: any): boolean {
    return value?.constructor == Object;
  }

  getCookie(name: string): any {
    let json = localStorage.getItem((this.path ?? '') + name);
    let obj = !json ? null : JSON.parse(json);
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

  static toDate(value: any): Date | null {
    if (!value) return null;
    else if (value.constructor == Date) return value;
    else return new Date(Date.parse(value.toString()));
  }

  static getDateTimeString(date: Date | null, locales: string = 'en-US'): string | undefined {
    return BaseComponent.toDate(date)?.toLocaleString(locales);
  }

  static getDateString(date: Date | null, locales: string = 'en-US'): string | undefined {
    return BaseComponent.toDate(date)?.toLocaleDateString(locales);
  }

  static getTimeString(time: Date | null): string | undefined {
    return BaseComponent.toDate(time)?.toLocaleTimeString();
  }

  static getRemain(date: Date | null, details: boolean = false): string {
    date = BaseComponent.toDate(date);
    if (date == null) return '';

    let result = [];
    let diff = date.getTime() - new Date().getTime();
    const negative = diff < 0;
    let slash;

    if (negative) {
      diff = -diff;
    }

    slash = Math.floor(diff / 86400000);
    if (slash > 0) {
      diff %= 86400000;
      result.push(slash + ' days');
    }

    if (slash > 0 && !details) return BaseComponent.JoinRemain(negative, result);

    slash = Math.floor(diff / 3600000);
    if (slash > 0) {
      diff %= 3600000;
      result.push(slash + ' hours');
    }

    if (slash > 0 && !details) return BaseComponent.JoinRemain(negative, result);

    slash = Math.floor(diff / 60000);
    if (slash > 0) {
      diff %= 60000;
      result.push(slash + ' minutes');
    }

    return BaseComponent.JoinRemain(negative, result);
  }

  private static JoinRemain(negative: boolean, parts: string[]): string {
    let final = parts.join(', ');
    if (negative) final = `(${final})`;

    return final;
  }
}
