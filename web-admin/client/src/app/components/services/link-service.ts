import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { ToasterComponent } from '@coreui/angular';

@Injectable({
  providedIn: 'root',
})
export class LinkService {

  constructor(private readonly router: Router) { }

  navigate(commands: any[]) {
    this.router.navigate(commands);
  }

  jump(commands: any[]) {
    const url = this.router.serializeUrl(this.router.createUrlTree(commands));
    window.open("#" + url, '_blank');
  }
}
