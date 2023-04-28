import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

// CoreUI Modules
import {
    TableModule,
    ButtonGroupModule,
    ButtonModule,
    CardModule,
    DropdownModule,
    GridModule,
    ProgressModule,
    SharedModule,
    WidgetModule,
    ModalModule,
} from '@coreui/angular';
import { IconModule } from '@coreui/icons-angular';
import { ChartjsModule } from '@coreui/angular-chartjs';

// utils
import { ListButtonsComponent } from './list/list-buttons/list-buttons.component';
import { TableViewComponent } from './list/table-view/table-view.component';
import { TablePageComponent } from './list/table-page/table-page.component';
import { WidgetViewComponent } from './list/widget-view/widget-view.component';
import { SelectComponent } from './list/selector/select.component';
import { FormButtonsComponent } from './form/form-buttons.component';
import { RouterModule } from '@angular/router';

@NgModule({
    declarations: [
        ListButtonsComponent,
        TableViewComponent,
        TablePageComponent,
        WidgetViewComponent,
        SelectComponent,
        FormButtonsComponent,
    ],
    imports: [
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
        RouterModule,
    ],
    exports: [
        ListButtonsComponent,
        TableViewComponent,
        TablePageComponent,
        WidgetViewComponent,
        SelectComponent,
        FormButtonsComponent,
    ]
})
export class ComponentsModule { }
