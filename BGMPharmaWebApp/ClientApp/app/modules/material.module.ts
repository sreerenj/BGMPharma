import { NgModule } from '@angular/core';
import { CdkTableModule } from '@angular/cdk/table';
import {

    MatButtonModule,
    MatSlideToggleModule,
    MatPaginatorModule,
    MatTableModule,
    MatToolbarModule,
    MatProgressSpinnerModule
} from '@angular/material';
@NgModule({
    imports: [
        MatButtonModule,
        MatSlideToggleModule,
        MatPaginatorModule,
        MatTableModule,
        MatToolbarModule,
        MatProgressSpinnerModule
    ],
    exports: [
        CdkTableModule,
        MatButtonModule,
        MatSlideToggleModule,
        MatTableModule,
        MatPaginatorModule,
        MatToolbarModule,
        MatProgressSpinnerModule
    ]
})
export class MaterialModule {

}
