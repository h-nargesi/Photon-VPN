import { ListViewModel } from './list-view.model';

export abstract class BaseComponent {

    protected abstract get columns_info(): ListViewModel | undefined;

    titleOf(name: string) {
        return this.columns_info != null && name in this.columns_info ? this.columns_info[name].title : name;
    }

    getDateTimeString(date: Date): string {
        return date.toLocaleString().replace('T', ' ');
    }

    getDateString(date: Date) {
        return date.toLocaleString().substring(0, 9).replace('-', '/');
    }

    getTimeString(time: Date) {
        return time.toLocaleString().substring(11, 20);
    }

    val(event: any): any {
        return event.target.value;
    }

}
