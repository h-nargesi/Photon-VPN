import { Component, EventEmitter, Input, Output } from "@angular/core";
import { ListViewComponent } from "../list-view.component";
import { ListViewModel, ListViewSchema } from "../list-view.model";
import { UIColors } from "./widget-view.model";

@Component({
  selector: 'app-widget-view',
  templateUrl: './widget-view.component.html',
})
export class WidgetViewComponent extends ListViewComponent {

  @Input("columns-info") columns_info: ListViewModel | undefined;
  @Input("columns-schema") columns_schema: ListViewSchema | undefined;
  @Output("selected") selectedEvent = new EventEmitter<Map<number, any>>();
  @Output("dbClick") doubleClicke = new EventEmitter<any>();
  @Output("editClick") edit = new EventEmitter<any>();
  @Output("removeClick") remove = new EventEmitter<any>();

  GetTitle(data: Data): string {
    const title = this.GetColumn('title', data) ?? '';
    let subtitle = this.GetColumn('subtitle', data)?.toString() ?? '';

    if (subtitle.length > 0)
      subtitle = ` $ ${subtitle}`;

    return title + subtitle;
  }

  GetColor(data: Data): string {
    const color = this.GetColumn('color', data);
    if (!color) return 'secondary';
    return UIColors[color];
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
