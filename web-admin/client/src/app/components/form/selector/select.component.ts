import { Component, ElementRef, EventEmitter, Input, Output } from '@angular/core';
import { SelectOptions } from '../../basical/base.models';
import { OptionService } from '../../services/option-service';

@Component({
  selector: '[app-select]',
  templateUrl: './select.component.html'
})
export class SelectComponent {

  public Items!: SelectOptions[];

  @Input('options') Options!: SelectOptions[];
  @Input('service') Service!: OptionService;
  @Input('lazy-load') lazy_load: boolean = false;
  @Input('default-id') default_id!: number;
  @Input('search') search: boolean = true;
  @Output("loaded") loaded = new EventEmitter();

  constructor(private ref: ElementRef) {

  }

  ngOnInit() {
    if (!this.lazy_load || this.default_id) this.Load();
  }

  Load() {
    this.Service?.Options().subscribe(
      (result: SelectOptions[]) => this.Items = this.Options = result);
  }

  filterItem(event: any) {
    event = event?.target?.value;

    if (!event) {
      this.Items = this.Options;
      this.ref.nativeElement.dispatchEvent(new Event('change'));

    } else if (typeof event === 'string') {
      event = event.toLowerCase();
      this.Items = this.Options?.filter(
        a => a.title.toLowerCase().includes(event));
      this.ref.nativeElement.dispatchEvent(new Event('change'));
    }
  }
}
