import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
})
export class FormComponent {

  @Input('title') title: string | undefined;
  @Input('comment') comment: string | undefined;
  @Input('list-route') list_route: string | undefined;
  @Input('is-new') is_new: boolean = true;
  
  @Output("submit") submit = new EventEmitter<any>();
  @Output("delete") delete = new EventEmitter<any>();

}
