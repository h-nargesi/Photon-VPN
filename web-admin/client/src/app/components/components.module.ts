import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

// CoreUI Modules
import { TableModule, ButtonGroupModule, ButtonModule } from '@coreui/angular';
import { IconModule } from '@coreui/icons-angular';

// utils
import { ListViewComponent } from './list-view/list-view.component';
import { ListButtonsComponent } from './list-buttons/list-buttons.component';

@NgModule({
    declarations: [
        ListViewComponent,
        ListButtonsComponent,
    ],
    imports: [
        CommonModule,
        TableModule,
        IconModule,
        ButtonGroupModule,
        ButtonModule,
    ],
    exports: [
        ListViewComponent,
        ListButtonsComponent,
    ]
})
export class ComponentsModule { }