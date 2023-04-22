import { Component, EventEmitter, Input, Output } from "@angular/core";
import { ListViewModel } from "./list-view.model";

@Component({
  selector: '[app-list-view]',
  templateUrl: './list-view.component.html',
})
export class ListViewComponent {

  @Input("columns-info") columns_info: ListViewModel | undefined;
  @Output("selected") selectedEvent = new EventEmitter<Map<number, any>>();

  private data_source: any[] = [];
  private data_columns: string[] = [];
  private selected_records: Map<number, any> = new Map<number, any>();

  get DataSource(): any[] {
    return this.data_source;
  }

  get DataColumns(): string[] {
    return this.data_columns;
  }

  get DisplayColumns(): string[] {
    return this.data_columns.slice();
  }

  get SelectedItems(): Map<number, any>  {
    return this.selected_records;
  }

  getTitle(name: string) {
    return this.columns_info != null ? this.columns_info[name].title : name;
  }

  selectRow(index: number) {
    if (index < 0 || index > this.data_source.length) return;
    const item = this.data_source[index];

    if (this.selected_records.has(index)) {
      this.selected_records.delete(index);

    } else {
      this.selected_records.set(index, item);
    }

    this.selectedEvent.emit(this.selected_records);
  }

  isSelected(index: number): boolean {
    return this.selected_records.has(index);
  }

  SetDataSource(data: any[]) {
    this.data_source = data;

    this.data_columns = [];

    if (this.columns_info) {
      for (const column in this.columns_info)
        if (this.columns_info[column].show && column in this.data_source[0])
          this.data_columns.push(column);

    } else if (this.data_source != null && this.data_source.length > 0) {
      for (const column in this.data_source[0])
        this.data_columns.push(column);
    }
  }
}
