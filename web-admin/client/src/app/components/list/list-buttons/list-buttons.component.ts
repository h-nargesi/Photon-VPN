import { Component, EventEmitter, Input, Output } from "@angular/core";

@Component({
  selector: 'app-list-buttons',
  templateUrl: './list-buttons.component.html',
})
export class ListButtonsComponent {

  @Input('show-reload') show_reload: boolean = true;
  @Input('show-add') show_add: boolean = true;
  @Input('show-edit') show_edit: boolean = true;
  @Input('show-remove') show_remove: boolean = true;
  @Input('show-undo') show_undo: boolean = true;
  
  @Output("reloadClick") realod = new EventEmitter<any>();
  @Output("addClick") add = new EventEmitter<any>();
  @Output("editClick") edit = new EventEmitter<any>();
  @Output("removeClick") remove = new EventEmitter<any>();
  @Output("undoClick") undo = new EventEmitter<any>();
}
