import { Component, Input } from '@angular/core';
import { OptionService } from '../..';
import { SelectOptions } from '../list-view.model';

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
