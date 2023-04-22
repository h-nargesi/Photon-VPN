import { Component, EventEmitter, Output } from "@angular/core";

@Component({
  selector: 'app-list-buttons',
  templateUrl: './list-buttons.component.html',
})
export class ListButtonsComponent {

  @Output("reloadClick") realod = new EventEmitter<any>();
  @Output("addClick") add = new EventEmitter<any>();
  @Output("editClick") edit = new EventEmitter<any>();
  @Output("removeClick") remove = new EventEmitter<any>();

  cilPencil = 'cilPencil';
  cilTrash = 'cilTrash';
  cilPlus = 'cilPlus';
  cilReload = 'cilReload';
}
