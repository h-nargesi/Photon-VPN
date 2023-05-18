import { Component, EventEmitter, Input, Output } from '@angular/core';
import { SelectOptions } from '../../basical/base.models';
import { OptionService } from '../../services/option-service';

@Component({
  selector: '[app-select]',
  templateUrl: './select.component.html'
})
export class SelectComponent {

  @Input('options') Options!: SelectOptions[];
  @Input('service') Service!: OptionService;
  @Input('lazy-load') lazy_load: boolean = false;
  @Input('default-id') default_id!: number;
  @Output("loaded") loaded = new EventEmitter();

  ngOnInit() {
    if (!this.lazy_load || this.default_id) this.Load();
  }

  Load() {
    this.Service?.Options().subscribe(
      (result: SelectOptions[]) => this.Options = result);
  }

}
