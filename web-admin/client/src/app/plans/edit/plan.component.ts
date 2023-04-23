import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Plan, PlanProfile, Profile } from '../plans.models';
import Titles from '../plans.json';
import { PlansService } from '../plans.service';
import { ListViewModel, Result, ResultStatus, UIColors } from '../../components';

@Component({
  selector: 'app-plan',
  templateUrl: './plan.component.html',
})
export class PlanComponent {

  private sub: any;
  public columns_info: ListViewModel = Titles.list;
  public item: PlanProfile = {
    id: 0,
    profile: {} as Profile,
    plan: {} as Plan
  } as PlanProfile;

  Colors = [
    { title: UIColors[UIColors.secondary], value: UIColors.secondary },
    { title: UIColors[UIColors.primary], value: UIColors.primary },
    { title: UIColors[UIColors.danger], value: UIColors.danger },
    { title: UIColors[UIColors.dark], value: UIColors.dark },
    { title: UIColors[UIColors.info], value: UIColors.info },
    { title: UIColors[UIColors.light], value: UIColors.light },
    { title: UIColors[UIColors.success], value: UIColors.success },
    { title: UIColors[UIColors.warning], value: UIColors.warning },
  ];

  constructor(
    private readonly service: PlansService,
    private readonly route: ActivatedRoute,
    private readonly router: Router) { }

  get Item(): PlanProfile {
    return this.item;
  }

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
      if ('id' in params) {
        this.service.Get(+params['id']).subscribe({
          next: (result: PlanProfile) => {
            this.item = result;
            if (!this.item.plan) this.item.plan = {} as Plan;
          },
          error: console.error
        });
      }
    });
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }

  getTitle(name: string) {
    return this.columns_info != null && name in this.columns_info ? this.columns_info[name].title : name;
  }

  val(event: any): any {
    return event.target.value;
  }

  Submit() {
    this.item.profile.cloudId = 23;

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
