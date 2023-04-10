import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { ActivatedRoute } from '@angular/router';
import { ListViewComponent } from '../../components/list-view.component';
import { UsersService } from '../users.service';

@Component({
  selector: 'app-users-sessions',
  templateUrl: './sessions.component.html',
})
export class SessionsComponent extends ListViewComponent implements OnInit {
  private user_id: number | null = null;

  constructor(
    title: Title,
    private readonly service: UsersService,
    private readonly route: ActivatedRoute) {
    super();
    title.setTitle("Sessions | Photon - VPN");
  }

  ngOnInit(): void {
    this.user_id = Number(this.route.snapshot.paramMap.get('user_id'));
    if (Number.isNaN(this.user_id)) {
      this.user_id = null;
    }
  }
}
