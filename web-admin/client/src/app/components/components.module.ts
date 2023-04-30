import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

// CoreUI Modules
import {
    ButtonGroupModule,
    ButtonModule,
    CardModule,
    DropdownModule,
    GridModule, ModalModule, ProgressModule,
    SharedModule, TableModule, WidgetModule
} from '@coreui/angular';
import { ChartjsModule } from '@coreui/angular-chartjs';
import { IconModule } from '@coreui/icons-angular';

// utils
import { ListButtonsComponent } from './list/list-buttons/list-buttons.component';
import { TablePageComponent } from './list/table-page/table-page.component';
import { TableViewComponent } from './list/table-view/table-view.component';
import { WidgetViewComponent } from './list/widget-view/widget-view.component';
import { SelectComponent } from './form/selector/select.component';
import { FormButtonsComponent } from './form/form-buttons/form-buttons.component';
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
