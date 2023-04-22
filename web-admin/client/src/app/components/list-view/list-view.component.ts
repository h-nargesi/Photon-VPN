import { Component, EventEmitter, Input, Output } from "@angular/core";
import { Observable } from "rxjs";
import { ListViewModel } from "./list-view.model";

@Component({
  selector: '[app-list-view]',
  templateUrl: './list-view.component.html',
})
export class ListViewComponent {

  @Input("data-provider") data_provider: Observable<any[]> | null = null;
  @Input("columns-info") columns_info: ListViewModel | null = null;
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

  selectRow(key: any) {
    if (this.selected_records.has(key)) this.selected_records.delete(key);
    else this.selected_records.add(key);
    this.selectedEvent.emit(this.selected_records);
  }

  isSelected(key: any): boolean {
    return this.selected_records.has(key);
  }

  ngOnInit(): void {
    this.data_provider?.subscribe({
      next: (result: any[]) => this.InitDataSource(result),
      error: console.error
    });
  }

  InitDataSource(data: any[]) {
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
