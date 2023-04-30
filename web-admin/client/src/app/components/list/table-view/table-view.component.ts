import { Component, EventEmitter, Input, Output } from "@angular/core";
import { ListViewComponent } from "../list-view.component";
import { EntitySchema } from "../../";

@Component({
  selector: '[app-table-view]',
  templateUrl: './table-view.component.html',
})
export class TableViewComponent extends ListViewComponent {

  @Input("selectable") selectable: boolean = true;
  @Input("columns-info") columns_info: EntitySchema | undefined;
  @Input("data-projection") data_projection: ((data: any[]) => any[]) | undefined;
  @Output("selected") selectedEvent = new EventEmitter<Map<number, any>>();
  @Output("double-click") double_click = new EventEmitter<any>();

}
