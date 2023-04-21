import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { ServerListComponent } from './list/server-list.component';

const routes: Routes = [
  {
    path: '',
    component: ServerListComponent,
    data: {
      title: 'Servers',
    },
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ServersRoutingModule {}

