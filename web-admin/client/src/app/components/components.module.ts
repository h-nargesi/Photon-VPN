import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

// CoreUI Modules
import { TableModule } from '@coreui/angular';

// utils
import { ListViewComponent } from './list-view/list-view.component';

@NgModule({
    declarations: [
        ListViewComponent,
    ],
    imports: [
        CommonModule,
        TableModule,
    ],
    exports: [
        ListViewComponent,
    ]
})
export class ComponentsModule { }