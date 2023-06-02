import { Component, EventEmitter, Input, Output } from "@angular/core";
import { Router } from "@angular/router";
import { EntitySchema, Filter, LGMDService, ListQuery } from "../../";
import { ListViewComponent } from "../list-view.component";

@Component({
  selector: 'app-table-view',
  templateUrl: './table-view.component.html',
  styles: [':host { width: 100%; display: block; }'],
})
export class TableViewComponent extends ListViewComponent {

  @Input("filter") filter: boolean = true;
  @Input("selectable") selectable: boolean = true;
  @Input("columns-info") columns_info!: EntitySchema;
  @Input("data-projection") data_projection!: ((data: any[]) => any[]);
  @Input("service") service!: LGMDService;
  @Input("default-filter") default_filter!: ListQuery;

  @Output("selected") selectedEvent = new EventEmitter<Map<number, any>>();
  @Output("double-click") double_click = new EventEmitter<any>();
  @Output("filter-changed") filter_changed = new EventEmitter<ListQuery>();
  @Output('reloading') reloading = new EventEmitter<ListQuery | null>();

  Query: ListQuery | null = null;
  Pages: { page: number, color: string }[] = [];
  private total_count: number = 0;

  constructor(router: Router) {
    super();
    this.path = router.url;
  }

  ngOnInit(): void {
    this.LoadQuary();
    this.Relaod();
  }

  GetStartOffset(): number {
    return this.Query?.start ?? 0;
  }

  Relaod() {
    this.service?.List(this.Query).subscribe((result: any[]) => {
      this.SetDataSource(result)
    });
    if (this.filter)
      this.service?.Count(this.Query).subscribe((result: number) => this.TotalCount = result);
    this.reloading.emit(this.Query);
  }

  SetFilterColumn(column: string, value: string) {
    if (!this.Query) return;
    if (!this.Query.filters) this.Query.filters = {};

    if (value.length == 0)
      delete this.Query.filters[column];

    else if (value == 'null')
      this.Query.filters[column] = { value: null } as Filter;

    else
      this.Query.filters[column] = { value: value } as Filter;

    this.Query.start = 0;

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
    } else this.Query.ordering[column] = true;

    this.OnFilterCanged();
  }

  SetSearch(key: string) {
    if (!this.Query) return;
    this.Query.search = key;
    this.Query.start = 0;
    this.OnFilterCanged();
  }

  GetSearch(): string {
    return this.Query?.search ?? '';
  }

  ClearFilters() {
    if (!this.Query) return;

    this.Query.start = this.default_filter?.start ?? 0;
    this.Query.search = this.default_filter?.search ?? null;

    if (this.default_filter?.filters) {
      this.Query.filters = {};
      for (const f in this.default_filter.filters)
        this.Query.filters[f] = this.default_filter.filters[f];
    }
    else this.Query.filters = null;

    if (this.default_filter?.ordering) {
      this.Query.ordering = {};
      for (const o in this.default_filter.ordering)
        this.Query.ordering[o] = this.default_filter.ordering[o];
    }
    else this.Query.ordering = null;

    this.OnFilterCanged();
  }

  GoPage(page: number) {
    if (!this.Query) return;
    if (!this.Query.limit) this.Query.limit = 5;

    this.Query.start = (page - 1) * this.Query.limit;
    this.OnFilterCanged();
  }

  PageSize(size: number) {
    if (!this.Query) return;
    this.Query.start = 0;
    this.Query.limit = size;
    this.OnFilterCanged();
  }

  get TotalCount(): number {
    return this.total_count;
  }

  set TotalCount(value: number) {
    this.total_count = value;
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

    this.Query = this.getCookie('query');

    if (!this.Query) {
      this.Query = { start: 0, limit: 5 };
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
  }

  private CalculatePagination() {
    this.Pages = [];
    if (!this.Query) return;
    if (!this.Query.start) this.Query.start = 0;
    if (!this.Query.limit) this.Query.limit = 5;

    const current_page = Math.floor(this.Query.start / this.Query.limit);

    const max_page = this.TotalCount < 0 ? 0 : Math.ceil(this.total_count / this.Query.limit);

    let start = current_page < 2 ? 0 : current_page - 2;

    let length = start + 5 <= max_page ? 5 : max_page - start;

    if (length < 5 && start > 0) {
      start -= 5 - length;
      if (start < 0) start = 0;
      length = start + 5 <= max_page ? 5 : max_page - start;
    }

    for (let i = 0; i < length; i++) {
      const page_number = i + start;
      let color: string;

      if (current_page == page_number)
        color = "primary";
      else if (page_number == 0 || 1 + page_number == max_page)
        color = "success";
      else
        color = "secondary";

      if (i == 0 && page_number != 0)
        this.Pages.push({
          page: 1,
          color: "success",
        });

      this.Pages.push({
        page: 1 + page_number,
        color: color,
      });

      if (i + 1 == length && page_number + 1 < max_page)
        this.Pages.push({
          page: max_page,
          color: "success",
        });
    }
  }

  private OnFilterCanged() {
    if (!this.Query) return;

    this.setCookie('query', this.Query);
    this.filter_changed.emit(this.Query);
    this.Relaod();
  }
}
