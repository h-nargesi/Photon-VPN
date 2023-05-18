import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent, EntitySchema, Result, ResultStatus, UIColors } from '../components';
import Titles from './plans.json';
import { Plan } from './plans.models';
import { PlansService } from './plans.service';

@Component({
  selector: 'app-plan',
  templateUrl: './plan.component.html',
})
export class PlanComponent extends BaseComponent {

  private sub: any;
  public Item: Plan = { title: '', active: true, created: new Date() } as Plan;
  public columns_info: EntitySchema = Titles.list;

  constructor(
    private readonly service: PlansService,
    private readonly route: ActivatedRoute,
    private readonly router: Router) {
    super();
  }

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
      if ('id' in params) {
        this.service.Get(+params['id']).subscribe((result: Plan) => this.Item = result);
      }
    });
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }

  Submit() {
    console.log(this.Item);

    this.service.Modify(this.Item).subscribe((result: Result) => {
      if (result.status < ResultStatus.Info && !this.Item.id)
        this.Item.id = Number(result.data);
    });
  }

  Delete() {
    if (!this.Item.id) return;

    this.service.Delete(this.Item.id).subscribe((result: Result) => {
      if (result.status < ResultStatus.Info)
        this.router.navigate(['plans']);
    });
  }

  get SessionCounts(): string {
    if (!this.Item || !this.Item.sessionCounts) return '';
    else return this.Item.sessionCounts.map(x => +x).sort(function (a, b) { return a - b }).toString();
  }

  set SessionCounts(value: string) {
    if (!this.Item) return;
    if (!value) this.Item.sessionCounts = [];
    if (!value.startsWith('[')) value = '[' + value;
    if (!value.endsWith(']')) value = value + ']';
    this.Item.sessionCounts = JSON.parse(value);
  }
}
