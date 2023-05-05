import { Component, EventEmitter, Input, Output } from "@angular/core";
import { ListViewComponent } from "../list-view.component";
import { CookieService, EntitySchema, Filter, LGMDService, ListQuery } from "../../";
import { Router } from "@angular/router";

@Component({
  selector: 'app-table-view',
  templateUrl: './table-view.component.html',
  styles: [':host { width: 100%; display: block; }'],
})
export class TableViewComponent extends ListViewComponent {

  @Input("filter") filter: boolean = true;
  @Input("selectable") selectable: boolean = true;
  @Input("columns-info") columns_info: EntitySchema | undefined;
  @Input("data-projection") data_projection: ((data: any[]) => any[]) | undefined;
  @Input("service") service: LGMDService | undefined;

  @Output("selected") selectedEvent = new EventEmitter<Map<number, any>>();
  @Output("double-click") double_click = new EventEmitter<any>();
  @Output("filter-changed") filter_changed = new EventEmitter<ListQuery>();

  Query: ListQuery | null = null;
  Pages: number[] = [];

  private pagination = {
    current_page: 0,
    total_count: 0,
  };

  constructor(router: Router) {
    super();
    this.path = router.url;
  }

  ngOnInit(): void {
    this.LoadQuary();
    this.Relaod();
  }

  Relaod() {
    this.service?.List(this.Query).subscribe({
      next: (result: any[]) => this.SetDataSource(result),
      error: console.error
    });
  }

  SetFilterColumn(column: string, value: string) {
    if (!this.Query) return;
    if (!this.Query.filters) this.Query.filters = {};
    this.Query.filters[column] = { value: value } as Filter;
    this.OnFilterCanged();
  }

  GetFilterColumn(column: string): string {
    if (!this.Query || !this.Query.filters) return '';
    return this.Query.filters[column]?.value ?? '';
  }

  ColumnSort(column: string) {
    if (!this.Query) return;
    if (!this.Query.ordering) this.Query.ordering = {};

    if (column in this.Query.ordering) {
      this.Query.ordering[column] = !this.Query.ordering[column];
    } else this.Query.ordering[column] = false;

    this.OnFilterCanged();
  }

  SetSearch(key: string) {
    if (!this.Query) return;
    this.Query.search = key;
    this.OnFilterCanged();
  }

  GetSearch(): string {
    return this.Query?.search ?? '';
  }

  ClearFilters() {
    if (!this.Query) return;

    this.Query.search = null;
    this.Query.filters = null;
    this.Query.ordering = null;

    this.OnFilterCanged();
  }

  GoPage(page: number) {
    if (!this.Query) return;
    if (!this.Query.limit) this.Query.limit = 5;

    this.Query.start = page * this.Query.limit;
    this.OnFilterCanged();
  }

  get TotalCount(): number {
    return this.pagination.total_count;
  }

  set TotalCount(value: number) {
    this.pagination.total_count = value;
    this.CalculatePagination();
  }

  override SetDataSource(data: any[]) {
    super.SetDataSource(data);
    this.CalculatePagination();
  }

  private LoadQuary() {
    if (this.Query) return;

    if (!this.filter) {
      this.Query = null;
      return;
    }

    console.log('path', this.path);

    this.Query = this.getCookie('query');

    if (!this.Query) {
      this.Query = { start: 0, limit: 5 } as ListQuery;
      this.setCookie('query', this.Query);
    }

    if (!this.Query.limit) {
      this.Query.limit = 5;
      this.setCookie('query', this.Query);
    }

    if (!this.Query.columns || this.Query.columns.length < 1) {
      this.Query.columns = [];
      if (this.columns_info) {
        for (const column in this.columns_info)
          if (this.columns_info[column].show)
            this.Query.columns.push(column);

        this.setCookie('query', this.Query);
      }

    } else if (this.columns_info) {
      for (const column in this.columns_info)
        this.columns_info[column].show = false;

      for (const column of this.Query.columns) {
        if (column in this.columns_info)
          this.columns_info[column].show = true;
      }
    }

    console.log('query', this.Query);
  }

  private CalculatePagination() {
    this.Pages = [];
    if (!this.Query) return;

    this.pagination.current_page = Math.floor(this.Query.start / this.Query.limit);
    console.log('current_page', this.pagination.current_page);

    const max_page = this.TotalCount < 0 ? 0 : Math.ceil(this.pagination.total_count / this.Query.limit);
    console.log('max_page', max_page);

    let start = this.pagination.current_page < 1 ? 0 : this.pagination.current_page - 2;
    console.log('start', start);

    const length = start + 4 <= max_page ? 4 : max_page - start;
    console.log('length', length);

    for (let i = 0; i < length; i++) this.Pages.push(1 + i + start);
    console.log('current_page', this.Pages);
  }

  private OnFilterCanged() {
    if (this.Query) {
      this.setCookie('query', this.Query);
      this.filter_changed.emit(this.Query);
      this.Relaod();
    }
  }
}
