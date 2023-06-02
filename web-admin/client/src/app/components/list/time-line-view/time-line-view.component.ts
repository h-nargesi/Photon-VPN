import { Component, EventEmitter, Input, Output } from "@angular/core";
import { ListViewComponent } from "../list-view.component";
import { BaseComponent, EntitySchema, UIColors } from "../../";
import { TimeLineSchema } from "./time-line-view.model";

type Data = { [name: string]: any };

@Component({
  selector: 'app-time-line-view',
  templateUrl: './time-line-view.component.html',
})
export class TimeLineViewComponent extends ListViewComponent {

  @Input("columns-info") columns_info: EntitySchema | undefined;
  @Input("columns-schema") columns_schema: TimeLineSchema | undefined;
  @Input("data-projection") data_projection: ((data: any[]) => any[]) | undefined;
  @Input("deletable") deletable: boolean = false;
  
  @Output("selected") selectedEvent = new EventEmitter<Map<number, any>>();
  @Output("double-click") double_click = new EventEmitter<any>();
  @Output("editClick") edit = new EventEmitter<any>();
  @Output("removeClick") remove = new EventEmitter<any>();

  protected selectable: boolean = false;

  GetTime(data: Data): string {
    const created = new Date(Date.parse(this.GetColumn('created', data)));
    const modified = new Date(Date.parse(this.GetColumn('modified', data)));
    let result = BaseComponent.getDateTimeString(created);

    if (created && modified && created.getTime() >= modified.getTime())
      result = `created:${result} / modified:${BaseComponent.getDateTimeString(modified)}`;

    return result ?? '';
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

  HasColumn(schema: string, data: Data): boolean {
    if (!this.columns_schema) return false;

    let column_name: string;
    if (schema in this.columns_schema) {
      column_name = this.columns_schema[schema];

    } else column_name = schema;

    return column_name in data;
  }
}
