import { Component } from '@angular/core';
import { Menu } from './nav-menu.model';
import { NavMenuService } from './nav-menu.service';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html'
})
export class NavMenuComponent {
  isExpanded = false;

  constructor(private service: NavMenuService) { }

  get Menu(): Menu | null {
    return this.service.Menu;
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
