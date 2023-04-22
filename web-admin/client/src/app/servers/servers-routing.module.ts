import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { ServerListComponent } from './list/server-list.component';
import { ServerComponent } from './edit/server.component';

const routes: Routes = [
  {
    path: '',
    data: {
      title: 'Servers',
    },
    children: [
      {
        path: '',
        component: ServerListComponent,
        data: {
          title: 'List Server'
        }
      },
      {
        path: 'edit',
        component: ServerComponent,
        data: {
          title: 'Edit Server'
        }
      },
      {
        path: 'edit/:id',
        component: ServerComponent,
        data: {
          title: 'Edit Server'
        }
      },
    ]
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ServersRoutingModule {}

