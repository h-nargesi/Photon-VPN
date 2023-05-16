import { ChangeDetectorRef, Component, ElementRef, forwardRef, Input, Renderer2 } from '@angular/core';

import { ToastComponent, ToasterService } from '@coreui/angular';

@Component({
  selector: 'app-notify',
  templateUrl: './notify.component.html',
  styles: [':host { display: block; overflow: hidden; }'],
})
export class NotifyComponent extends ToastComponent {

  @Input() closeButton = true;
  @Input() title = '';
  @Input() description = '';

  constructor(
    public override hostElement: ElementRef,
    public override renderer: Renderer2,
    public override toasterService: ToasterService,
    public override changeDetectorRef: ChangeDetectorRef
  ) {
    super(hostElement, renderer, toasterService, changeDetectorRef);
  }
}
