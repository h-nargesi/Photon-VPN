import { Component, EventEmitter, Input, Output } from "@angular/core";
import { ListViewModel } from "./list-view.model";

@Component({
  selector: '[app-list-view]',
  templateUrl: './list-view.component.html',
})
export class ListViewComponent {

  @Input("columns-info") columns_info: ListViewModel | undefined;
  @Output("selected") selectedEvent = new EventEmitter<Set<any>>();

  private data_source: any[] = [];
  private data_columns: string[] = [];
  private selected_records: Set<any> = new Set<any>();

  get DataSource(): any[] {
    return this.data_source;
  }

  get DataColumns(): string[] {
    return this.data_columns;
  }

  get DisplayColumns(): string[] {
    return this.data_columns.slice();
  }

  getTitle(name: string) {
    return this.columns_info != null ? this.columns_info[name].title : name;
  }

  selectRow(index: number) {
    if (index < 0 || index > this.data_source.length) return;
    const item = this.data_source[index];

    if (this.selected_records.has(item)) this.selected_records.delete(item);
    else this.selected_records.add(item);
    
    this.selectedEvent.emit(this.selected_records);
  }

  isSelected(key: any): boolean {
    return this.selected_records.has(key);
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
