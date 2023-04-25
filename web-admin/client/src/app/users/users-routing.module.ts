import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { UsersListComponent } from './user-list.component';
import { UserComponent } from './edit/user.component';

const routes: Routes = [
  {
    path: '',
    data: {
      title: 'Users',
    },
    children: [
      {
        path: '',
        component: UsersListComponent,
        data: {
          title: 'Users List'
        }
      },
      {
        path: 'edit',
        component: UserComponent,
        data: {
          title: 'Add User'
        }
      },
      {
        path: 'edit/:id',
        component: UserComponent,
        data: {
          title: 'Edit User'
        }
      },
    ]
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class UsersRoutingModule { }
