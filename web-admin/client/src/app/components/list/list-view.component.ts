import { EventEmitter } from "@angular/core";
import { BaseComponent } from "../basical/base.component";

export abstract class ListViewComponent extends BaseComponent {

  private click = { time: 0, index: -1 };
  private data_source: any[] = [];
  private data_columns: string[] = [];
  private selected_records: Map<number, any> = new Map<number, any>();

  protected abstract get selectable(): boolean | undefined;
  protected abstract get selectedEvent(): EventEmitter<Map<number, any>>;
  protected abstract get doubleClicke(): EventEmitter<any>;

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
      this.doubleClicke.emit(item);

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
    this.data_source = data;

    this.data_columns = [];

    if (this.columns_info) {
      for (const column in this.columns_info)
        if (this.columns_info[column].show && this.data_source[0] && column in this.data_source[0])
          this.data_columns.push(column);

    } else if (this.data_source != null && this.data_source.length > 0) {
      for (const column in this.data_source[0])
        this.data_columns.push(column);
    }
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
