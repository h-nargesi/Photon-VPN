import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';

// CoreUI Modules
import {
  AccordionModule,
  BadgeModule,
  BreadcrumbModule,
  ButtonGroupModule,
  ButtonModule,
  CardModule,
  CarouselModule,
  CollapseModule,
  DropdownModule,
  FormModule,
  GridModule,
  ListGroupModule,
  NavModule,
  PaginationModule,
  PlaceholderModule,
  PopoverModule,
  ProgressModule,
  SharedModule,
  SpinnerModule,
  TableModule,
  UtilitiesModule,
  TabsModule,
} from '@coreui/angular';

import { IconModule } from '@coreui/icons-angular';

// utils
import { DocsComponentsModule } from '@docs-components/docs-components.module';
import { ComponentsModule } from '../components/components.module';

// views
import { UserListComponent } from './user-list.component';
import { UserComponent } from './user.component';
import { UserInfoComponent } from './info/user-info.component';
import { UserLogsComponent } from './logs/log.component';

// Components Routing
import { UsersRoutingModule } from './users-routing.module';

@NgModule({
  declarations: [
    UserListComponent,
    UserComponent,
    UserInfoComponent,
    UserLogsComponent,
  ],
  imports: [
    CommonModule,
    UsersRoutingModule,
    AccordionModule,
    BadgeModule,
    BreadcrumbModule,
    ButtonGroupModule,
    ButtonModule,
    CardModule,
    CollapseModule,
    GridModule,
    UtilitiesModule,
    SharedModule,
    ListGroupModule,
    IconModule,
    ListGroupModule,
    PlaceholderModule,
    ProgressModule,
    SpinnerModule,
    NavModule,
    CarouselModule,
    FormModule,
    ReactiveFormsModule,
    DropdownModule,
    PaginationModule,
    PopoverModule,
    TableModule,
    DocsComponentsModule,
    ComponentsModule,
    TabsModule,
  ],
})
export class UsersModule { }
