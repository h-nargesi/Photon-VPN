import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

// CoreUI Modules
import {
  AlertComponent,
  ButtonGroupModule,
  ButtonModule,
  CardModule,
  DropdownModule,
  GridModule,
  ModalModule,
  ProgressModule,
  SharedModule,
  TableModule, ToastModule, WidgetModule
} from '@coreui/angular';
import { ChartjsModule } from '@coreui/angular-chartjs';
import { IconModule } from '@coreui/icons-angular';

// utils
import { RouterModule } from '@angular/router';
import { NotifyComponent } from './basical/notify/notify.component';
import { FormButtonsComponent } from './form/form-buttons/form-buttons.component';
import { SelectComponent } from './form/selector/select.component';
import { ListButtonsComponent } from './list/list-buttons/list-buttons.component';
import { TablePageComponent } from './list/table-page/table-page.component';
import { TableViewComponent } from './list/table-view/table-view.component';
import { TimeLineViewComponent } from './list/time-line-view/time-line-view.component';
import { WidgetViewComponent } from './list/widget-view/widget-view.component';

@NgModule({
  declarations: [
    ListButtonsComponent,
    TableViewComponent,
    TablePageComponent,
    WidgetViewComponent,
    TimeLineViewComponent,
    SelectComponent,
    FormButtonsComponent,
    NotifyComponent,
  ],
  imports: [
    AlertComponent,
    CommonModule,
    TableModule,
    IconModule,
    ButtonGroupModule,
    ButtonModule,
    CardModule,
    DropdownModule,
    GridModule,
    ProgressModule,
    SharedModule,
    WidgetModule,
    ChartjsModule,
    ModalModule,
    ToastModule,
    RouterModule,
  ],
  exports: [
    ListButtonsComponent,
    TableViewComponent,
    TablePageComponent,
    WidgetViewComponent,
    TimeLineViewComponent,
    SelectComponent,
    FormButtonsComponent,
    NotifyComponent,
  ]
})
export class ComponentsModule { }
