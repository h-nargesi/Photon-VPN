import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-form',
  templateUrl: './form-buttons.component.html',
})
export class FormButtonsComponent {

  @Input('list-route') list_route: string | undefined;
  @Input('is-new') is_new: boolean = true;
  @Input('show-mode') show_mode: number = 7;
  
  @Output("submit") submit = new EventEmitter<any>();
  @Output("cancel") cancel = new EventEmitter<any>();
  @Output("delete") delete = new EventEmitter<any>();

  Mode(mask: number): boolean {
    return mask == (mask & this.show_mode);
  }
}
