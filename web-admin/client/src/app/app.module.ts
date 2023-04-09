import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { NavHeaderComponent } from './components/nav-header/nav-header.component';
import { ListViewComponent } from './components/list-view/list-view.component';
import { DashbordComponent } from './dashbord/dashbord.component';
import { UsersComponent } from './users/users.component';
import { ProfileComponent } from './users/profile/profile.component';
import { SessionsComponent } from './users/sessions/sessions.component';
import { PaymentsComponent } from './users/payments/payments.component';
import { PlansComponent } from './plans/plans.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    NavHeaderComponent,
    ListViewComponent,
    DashbordComponent,
    UsersComponent,
    ProfileComponent,
    SessionsComponent,
    PaymentsComponent,
    PlansComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: DashbordComponent, pathMatch: 'full' },
      { path: 'users', component: UsersComponent },
      { path: 'users/profile', component: ProfileComponent },
      { path: 'users/sessions', component: SessionsComponent },
      { path: 'users/payments', component: PaymentsComponent },
      { path: 'plans', component: PlansComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
