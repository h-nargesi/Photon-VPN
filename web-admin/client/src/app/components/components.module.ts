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
import { SelectComponent } from './list/selector/select.component';
import { TablePageComponent } from './list/table-page/table-page.component';
import { TableViewComponent } from './list/table-view/table-view.component';
import { WidgetViewComponent } from './list/widget-view/widget-view.component';

@NgModule({
    declarations: [
        ListButtonsComponent,
        TableViewComponent,
        TablePageComponent,
        WidgetViewComponent,
        SelectComponent,
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
    ],
    exports: [
        ListButtonsComponent,
        TableViewComponent,
        TablePageComponent,
        WidgetViewComponent,
        SelectComponent,
    ]
})
export class ComponentsModule { }
