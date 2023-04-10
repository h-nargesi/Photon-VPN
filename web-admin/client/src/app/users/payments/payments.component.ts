import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { Payment } from './payments.model';
import { PaymentsService } from './payments.service';
import { ActivatedRoute } from '@angular/router';
import { ListViewComponent } from '../../components/list-view.component';

@Component({
  selector: 'app-users-payments',
  templateUrl: './payments.component.html',
})
export class PaymentsComponent extends ListViewComponent implements OnInit {
  private user_id: number | null = null;

  constructor(
    title: Title,
    private readonly service: PaymentsService,
    private readonly route: ActivatedRoute) {
    super();
    title.setTitle("Payments | Photon - VPN");
  }

  ngOnInit(): void {
    this.user_id = Number(this.route.snapshot.paramMap.get('user_id'));
    if (Number.isNaN(this.user_id)) {
      this.user_id = null;
    }
    this.service.List(this.user_id)
      .subscribe({
        next: (result: Payment[]) => this.InitDataSource(result),
        error: console.error
      });
  }
}
