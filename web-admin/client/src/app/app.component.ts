import { Component, OnInit, ViewChild } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';

import { Title } from '@angular/platform-browser';
import { ToasterComponent } from '@coreui/angular';
import { IconSetService } from '@coreui/icons-angular';
import { NotifyService } from './components';
import { iconSubset } from './icons/icon-subset';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
})
export class AppComponent implements OnInit {
  title = 'Photon - VPN';

  @ViewChild('Toaster') toaster!: ToasterComponent;

  constructor(
    private router: Router,
    private notify_service: NotifyService,
    titleService: Title,
    iconSetService: IconSetService
  ) {
    titleService.setTitle(this.title);
    // iconSet singleton
    iconSetService.icons = { ...iconSubset };
  }

  ngOnInit(): void {
    this.router.events.subscribe((evt) => {
      if (!(evt instanceof NavigationEnd)) {
        return;
      }
    });
  }

  ngAfterViewInit() {
    this.notify_service.setToaster(this.toaster);
  }

}
