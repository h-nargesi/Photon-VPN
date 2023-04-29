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
    UtilitiesModule
} from '@coreui/angular';

import { IconModule } from '@coreui/icons-angular';

// utils
import { DocsComponentsModule } from '@docs-components/docs-components.module';
import { ComponentsModule } from '../components/components.module';

// views
import { PlanComponent } from './edit/plan.component';
import { PlanListComponent } from './list/plan-list.component';

// Components Routing
import { PlansRoutingModule } from './plans-routing.module';

@NgModule({
  declarations: [
    PlanListComponent,
    PlanComponent,
  ],
  imports: [
    CommonModule,
    PlansRoutingModule,
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
  ],
})
export class PlansModule {}
