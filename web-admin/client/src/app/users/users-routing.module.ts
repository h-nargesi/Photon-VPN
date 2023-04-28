import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { UserListComponent } from './user-list.component';
import { UserComponent } from './user.component';

const routes: Routes = [
  {
    path: '',
    data: {
      title: 'Users',
    },
    children: [
      {
        path: '',
        component: UserListComponent,
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
