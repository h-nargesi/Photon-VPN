import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { ActivatedRoute } from '@angular/router';
import { ListViewComponent } from '../../components/list-view.component';
import { SessionsService } from './sessions.service';
import { Session } from './sessions.model';

@Component({
  selector: 'app-users-sessions',
  templateUrl: './sessions.component.html',
})
export class SessionsComponent extends ListViewComponent implements OnInit {
  public only_open: boolean = true;

  constructor(
    title: Title,
    private readonly service: SessionsService,
    private readonly route: ActivatedRoute) {
    super();
    title.setTitle("Sessions | Photon - VPN");
  }

  ngOnInit(): void {
    this.service.List(this.only_open)
      .subscribe({
        next: (result: Session[]) => this.InitDataSource(result),
        error: console.error
      });
  }
}
