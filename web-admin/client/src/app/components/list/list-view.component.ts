import { EventEmitter } from "@angular/core";
import { BaseComponent } from "../basical/base.component";
import { EntitySchema, ShowType } from "../basical/base.models";

export abstract class ListViewComponent extends BaseComponent {

  private click = { time: 0, index: -1 };
  private data_source: any[] = [];
  private data_columns: string[] = [];
  private selected_records: Map<number, any> = new Map<number, any>();

  protected abstract get selectable(): boolean | undefined;
  protected abstract get data_projection(): ((data: any[]) => any[]) | undefined;
  protected abstract get selectedEvent(): EventEmitter<Map<number, any>>;
  protected abstract get double_click(): EventEmitter<any>;

  get DataSource(): any[] {
    return this.data_source;
  }

  get DataColumns(): string[] {
    return this.data_columns;
  }

  get DisplayColumns(): string[] {
    return this.data_columns.slice();
  }

  get SelectedItems(): Map<number, any> {
    return this.selected_records;
  }

  SelectRow(index: number) {
    if (!this.selectable) return;
    if (index < 0 || index > this.data_source.length) return;
    const item = this.data_source[index];

    if (this.selected_records.has(index)) {
      this.selected_records.delete(index);

    } else {
      this.selected_records.set(index, item);
    }

    if (this.is_double_click(index)) {
      this.double_click.emit(item);

    } else {
      this.selectedEvent.emit(this.selected_records);
    }
  }

  IsSelected(index: number): boolean {
    return this.selected_records.has(index);
  }

  ClearSelected() {
    this.selected_records.clear();
    this.selectedEvent.emit(this.selected_records);
  }

  SetDataSource(data: any[]) {
    this.data_source = this.project(data);

    this.data_columns = [];

    if (this.data_source != null && this.data_source.length > 0) {
      const sample = this.data_source[0];
      if (this.columns_info) {
        for (const column in this.columns_info)
          if (this.columns_info[column].show && column in sample)
            this.data_columns.push(column);

      } else {
        for (const column in sample)
          this.data_columns.push(column);
      }
    } else if (this.columns_info) {
      for (const column in this.columns_info)
        if (this.columns_info[column].show)
          this.data_columns.push(column);
    }
  }

  private project(data: any[]): any[] {
    if (this.data_projection)
      data = this.data_projection(data);

    if (this.columns_info && data != null && data.length > 0) {
      for (const column in this.columns_info) {
        if (!this.columns_info[column].type || !(column in data[0]))
          continue;
        switch (this.columns_info[column].type) {
          case ShowType.datetime:
            for (var d of data) {
              var date = BaseComponent.toDate(d[column]);
              d[column] = {
                'Display': BaseComponent.getDateTimeString(date),
                'Tooltip': [
                  BaseComponent.getDateTimeString(date, 'fa-IR'),
                  BaseComponent.getRemain(date)
                ].join('\n'),
              }
            }
            break;
          case ShowType.date:
            for (var d of data) {
              var date = BaseComponent.toDate(d[column]);
              d[column] = {
                'Display': BaseComponent.getDateString(date),
                'Tooltip': [
                  BaseComponent.getDateString(date, 'fa-IR'),
                  BaseComponent.getRemain(date)
                ].join('\n'),
              };
            }
            break;
          case ShowType.jalali:
            for (var d of data) {
              var date = BaseComponent.toDate(d[column]);
              d[column] = {
                'Display': BaseComponent.getDateString(date, 'fa-IR'),
                'Tooltip': [
                  BaseComponent.getDateString(date),
                  BaseComponent.getRemain(date)
                ].join('\n'),
              };
            }
            break;
          case ShowType.time:
            for (var d of data) d[column] = BaseComponent.getTimeString(d[column]);
            break;
          case ShowType.duration:
            for (var d of data) {
              var date = BaseComponent.toDate(d[column]);
              d[column] = {
                'Display': BaseComponent.getRemain(date),
                'Tooltip': [
                  BaseComponent.getDateString(date),
                  BaseComponent.getDateString(date, 'fa-IR'),
                ].join('\n'),
              };
            }
            break;

        }
      }
    }

    return data;
  }

  private is_double_click(index: number): boolean {
    const now = new Date().getTime();
    let result: boolean;

    if (this.click.index == index &&
      now - this.click.time <= 250) {
      result = true;
      this.click.index = -1;
      this.click.time = 0;

    } else {
      result = false;
      this.click.index = index;
      this.click.time = now;
    }

    return result;
  }
}
