import { Component, EventEmitter, Input, Output } from "@angular/core";
import { ListViewComponent } from "../list-view.component";
import { ListViewModel, ListViewSchema } from "../list-view.model";

@Component({
  selector: 'app-widget-view',
  templateUrl: './widget-view.component.html',
})
export class WidgetViewComponent extends ListViewComponent {

  @Input("columns-info") columns_info: ListViewModel | undefined;
  @Input("columns-schema") columns_schema: ListViewSchema | undefined;
  @Output("selected") selectedEvent = new EventEmitter<Map<number, any>>();
  @Output("dbClick") doubleClicke = new EventEmitter<any>();

  GetTitle(data: Data): string {
    const title = this.GetColumn('title', data) ?? '';
    let subtitle = this.GetColumn('subtitle', data) ?? '';

    if (subtitle && subtitle.length > 0)
      subtitle = ` <small>${subtitle}</small>`;

    return title + subtitle;
  }

  GetColor(data: Data): string {
    return this.GetColumn('color', data)?.toString() ?? 'secondary';
  }

  GetColumn(schema: string, data: Data): any {
    if (!this.columns_schema) return undefined;

    let column_name: string;
    if (schema in this.columns_schema) {
      column_name = this.columns_schema[schema];

    } else column_name = schema;

    return data[column_name];
  }

}

type Data = { [name: string]: any };
