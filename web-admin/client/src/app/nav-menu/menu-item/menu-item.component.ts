import { Component } from "@angular/core";
import { Menu } from "../nav-menu.model";

@Component({
  selector: 'app-menu-item',
  inputs: ['menu'],
  template: './menu-item.component.html'
})
export class MenuItemComponent {
  HasChild(menu: Menu): boolean {
    return menu.Items.length > 0;
  }
}
