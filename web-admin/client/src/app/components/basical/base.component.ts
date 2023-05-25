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

  static getDateTimeString(date: Date | null): string {
    if (!date) return '';
    else return BaseComponent.getDateString(date) + ' ' + BaseComponent.getTimeString(date);
  }

  static getDateString(date: Date | null): string | undefined {
    return date?.toLocaleString().substring(0, 10);
  }

  static getTimeString(time: Date | null): string | undefined {
    return time?.toLocaleString().substring(11, 19);
  }

  static getRemain(date: Date | null, details: boolean = false): string {
    if (date == null) return '';

    date = new Date(Date.parse(date.toString()));

    let result = [];
    let diff = date.getTime() - new Date().getTime();
    let slash;

    if (diff < 0) {
      diff = -diff;
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
