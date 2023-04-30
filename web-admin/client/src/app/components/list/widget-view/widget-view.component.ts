import { Component, EventEmitter, Input, Output } from "@angular/core";
import { ListViewComponent } from "../list-view.component";
import { EntitySchema, UIColors } from "../../";
import { WidgetSchema } from "./widget-view.model";

type Data = { [name: string]: any };

@Component({
  selector: 'app-widget-view',
  templateUrl: './widget-view.component.html',
})
export class WidgetViewComponent extends ListViewComponent {

  @Input("columns-info") columns_info: EntitySchema | undefined;
  @Input("columns-schema") columns_schema: WidgetSchema | undefined;
  @Input("data-projection") data_projection: ((data: any[]) => any[]) | undefined;
  @Output("selected") selectedEvent = new EventEmitter<Map<number, any>>();
  @Output("double-click") double_click = new EventEmitter<any>();
  @Output("editClick") edit = new EventEmitter<any>();
  @Output("removeClick") remove = new EventEmitter<any>();
  
  protected selectable: boolean = false;

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
