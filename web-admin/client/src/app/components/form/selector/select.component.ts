import { Component, Input } from '@angular/core';
import { OptionService } from '../../services/option-service';
import { SelectOptions } from '../../basical/base.models';

@Component({
  selector: '[app-select]',
  templateUrl: './select.component.html'
})
export class SelectComponent {

  constructor() { }

  @Input('options') Options: SelectOptions[] | undefined;
  @Input('service') Service: OptionService | undefined;
  @Input('lazy-load') lazy_load: boolean = false;

  ngOnInit() {
    if (!this.lazy_load) this.Load();
  }

  Load() {
    this.Service?.Options(null).subscribe({
      next: (result: SelectOptions[]) => this.Options = result,
      error: console.error
    });
  }

}
