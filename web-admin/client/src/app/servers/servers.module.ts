import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';

// CoreUI Modules
import {
  AccordionModule,
  ButtonModule,
  BadgeModule,
  BreadcrumbModule,
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
} from '@coreui/angular';

import { IconModule } from '@coreui/icons-angular';

// utils
import { DocsComponentsModule } from '@docs-components/docs-components.module';
import { ComponentsModule } from '../components/components.module';

// views
import { ServerListComponent } from './list/server-list.component';
import { ServerComponent } from './edit/server.component';

// Components Routing
import { ServersRoutingModule } from './servers-routing.module';

@NgModule({
  declarations: [
    ServerListComponent,
    ServerComponent,
  ],
  imports: [
    CommonModule,
    ButtonModule,
    ServersRoutingModule,
    AccordionModule,
    BadgeModule,
    BreadcrumbModule,
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
  ],
})
export class ServersModule {}
