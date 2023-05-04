import { Component, EventEmitter, Input, Output } from "@angular/core";
import { ListViewComponent } from "../list-view.component";
import { CookieService, EntitySchema, Filter, ListQuery } from "../../";
import { Router } from "@angular/router";

@Component({
  selector: '[app-table-view]',
  templateUrl: './table-view.component.html',
})
export class TableViewComponent extends ListViewComponent {

  @Input("filter") filter: boolean = false;
  @Input("selectable") selectable: boolean = true;
  @Input("columns-info") columns_info: EntitySchema | undefined;
  @Input("data-projection") data_projection: ((data: any[]) => any[]) | undefined;
  @Output("selected") selectedEvent = new EventEmitter<Map<number, any>>();
  @Output("double-click") double_click = new EventEmitter<any>();
  @Output("filter-changed") filter_changed = new EventEmitter<ListQuery>();

  Query: ListQuery | null = null;

  constructor(router: Router,
    protected override readonly cookies: CookieService) {
    super();

    if (this.filter) {
      this.path = router.url;

      this.setCookie('query-test', router.url);
      this.getCookie('query-test');

      this.Query = this.getCookie('query');

      if (!this.Query) this.Query = {} as ListQuery;

      if (!this.Query.columns) {
        this.Query.columns = [];
        if (this.columns_info) {
          for (const column in this.columns_info)
            if (this.columns_info[column].show)
              this.Query.columns.push(column);
        }

      } else if (this.columns_info) {
        for (const column in this.columns_info)
          this.columns_info[column].show = false;

        for (const column in this.Query.columns)
          if (column in this.columns_info)
            this.columns_info[column].show = true;
      }

      this.setCookie('query', this.Query);
    }
  }

  SetFilterColumn(column: string, value: string) {
    if (!this.Query) return;
    if (!this.Query.filters) this.Query.filters = {};
    this.Query.filters[column] = { value: value } as Filter;
  }

  GetFilterColumn(column: string): string {
    if (!this.Query || !this.Query.filters) return '';
    return this.Query.filters[column].value ?? '';
  }

  override SetDataSource(data: any[]) {
    super.SetDataSource(data);

    if (this.filter) {

    }
  }
}
