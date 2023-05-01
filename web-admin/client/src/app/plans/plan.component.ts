import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Plan } from './plans.models';
import Titles from './plans.json';
import { PlansService } from './plans.service';
import { BaseComponent, EntitySchema, Result, ResultStatus, UIColors } from '../components';

@Component({
  selector: 'app-plan',
  templateUrl: './plan.component.html',
})
export class PlanComponent extends BaseComponent {

  private sub: any;
  private item: Plan = { title: '', active: true, created: new Date() } as Plan;
  public columns_info: EntitySchema = Titles.list;

  Colors = [
    { title: UIColors[UIColors.secondary], id: UIColors.secondary },
    { title: UIColors[UIColors.primary], id: UIColors.primary },
    { title: UIColors[UIColors.danger], id: UIColors.danger },
    { title: UIColors[UIColors.dark], id: UIColors.dark },
    { title: UIColors[UIColors.info], id: UIColors.info },
    { title: UIColors[UIColors.light], id: UIColors.light },
    { title: UIColors[UIColors.success], id: UIColors.success },
    { title: UIColors[UIColors.warning], id: UIColors.warning },
  ];

  constructor(
    private readonly service: PlansService,
    private readonly route: ActivatedRoute,
    private readonly router: Router) {
    super();
  }

  get Item(): Plan {
    return this.item;
  }

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
      if ('id' in params) {
        this.service.Get(+params['id']).subscribe({
          next: (result: Plan) => this.item = result,
          error: console.error
        });
      }
    });
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }

  Submit() {
    console.log(this.item);

    this.service.Modify(this.item).subscribe({
      next: (result: Result) => {
        if (result.status >= ResultStatus.Invalid) console.error(result);
        else {
          console.info(result);
          if (!this.item.id) this.item.id = Number(result.data);
        }
      },
      error: console.error
    });
  }

  Delete() {
    if (!this.item.id) return;

    this.service.Delete(this.item.id).subscribe({
      next: (result: Result) => {
        if (result.status >= ResultStatus.Invalid) console.error(result);
        else this.router.navigate(['plans']);
      },
      error: console.error
    });
  }
}
