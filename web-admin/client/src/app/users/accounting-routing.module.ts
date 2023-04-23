import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { UsersComponent } from './users/users.component';

const routes: Routes = [
  {
    path: '',
    data: {
      title: 'Accouting',
    },
    children: [
      {
        path: 'users',
        component: UsersComponent,
        data: {
          title: 'Users List'
        }
      },
    ]
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AccountingRoutingModule { }

