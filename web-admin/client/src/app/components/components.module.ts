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
} from '@coreui/angular';
import { IconModule } from '@coreui/icons-angular';
import { ChartjsModule } from '@coreui/angular-chartjs';

// utils
import { ListButtonsComponent } from './list/list-buttons/list-buttons.component';
import { TableViewComponent } from './list/table-view/table-view.component';
import { WidgetViewComponent } from './list/widget-view/widget-view.component';

@NgModule({
    declarations: [
        ListButtonsComponent,
        TableViewComponent,
        WidgetViewComponent,
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
    ],
    exports: [
        ListButtonsComponent,
        TableViewComponent,
        WidgetViewComponent,
    ]
})
export class ComponentsModule { }