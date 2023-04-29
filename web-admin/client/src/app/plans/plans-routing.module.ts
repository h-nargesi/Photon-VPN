import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { PlanComponent } from './edit/plan.component';
import { PlanListComponent } from './list/plan-list.component';

const routes: Routes = [
  {
    path: '',
    data: {
      title: 'Plans',
    },
    children: [
      {
        path: '',
        component: PlanListComponent,
        data: {
          title: 'Plan List'
        }
      },
      {
        path: 'edit',
        component: PlanComponent,
        data: {
          title: 'Add Plan'
        }
      },
      {
        path: 'edit/:id',
        component: PlanComponent,
        data: {
          title: 'Edit Plan'
        }
      },
    ]
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class PlansRoutingModule {}

