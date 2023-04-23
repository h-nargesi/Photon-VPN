import { Component, EventEmitter, Input, Output } from "@angular/core";

@Component({
  selector: 'app-list-buttons',
  templateUrl: './list-buttons.component.html',
})
export class ListButtonsComponent {

  @Input('reload') show_reload: boolean = true;
  @Input('add') show_add: boolean = true;
  @Input('edit') show_edit: boolean = true;
  @Input('remove') show_remove: boolean = true;

  @Output("reloadClick") realod = new EventEmitter<any>();
  @Output("addClick") add = new EventEmitter<any>();
  @Output("editClick") edit = new EventEmitter<any>();
  @Output("removeClick") remove = new EventEmitter<any>();

  cilPencil = 'cilPencil';
  cilTrash = 'cilTrash';
  cilPlus = 'cilPlus';
  cilReload = 'cilReload';
}
