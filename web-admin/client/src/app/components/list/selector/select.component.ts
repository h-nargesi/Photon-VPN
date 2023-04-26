import { Component, Input } from '@angular/core';
import { SelectOptions } from '../list-view.model'
import { OptionService } from '../..';

@Component({
  selector: '[app-select]',
  templateUrl: './select.component.html'
})
export class SelectComponent {

  constructor() { }

  @Input('options') Options: SelectOptions[] | undefined;
  @Input('service') Service: OptionService | undefined;

  ngOnInit() {
    this.Service?.Options(null).subscribe({
      next: (result: SelectOptions[]) => this.Options = result,
      error: console.error
    });
  }

}
