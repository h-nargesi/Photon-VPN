import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { EntityService, NotifyService } from '../components';
import { Payment, PaymentList } from './payments.model';

@Injectable({
  providedIn: 'root',
})
export class PaymentsService extends EntityService<PaymentList, Payment> {

  constructor(
    http: HttpClient,
    notify_service: NotifyService,
    @Inject('API_URL') api_url: string,
    @Inject('BASE_URL') base_url: string) {
    super(http, notify_service, api_url, base_url, 'payments');
  }

  public SetUserId(user_id: number): PaymentsService {
    super.ClearQueryString();
    super.SetQueryString('user_id', user_id);
    return this;
  }

}
