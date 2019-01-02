import { NgModule } from '@angular/core';
import { CdkTableModule } from '@angular/cdk/table';
import {

    MatButtonModule,
    MatSlideToggleModule,
    MatPaginatorModule,
    MatTableModule,
    MatToolbarModule,
    MatProgressSpinnerModule,
    MatSortModule
} from '@angular/material';
@NgModule({
    imports: [
        MatButtonModule,
        MatSlideToggleModule,
        MatPaginatorModule,
        MatTableModule,
        MatToolbarModule,
        MatProgressSpinnerModule,
        MatSortModule
    ],
    exports: [
        CdkTableModule,
        MatButtonModule,
        MatSlideToggleModule,
        MatTableModule,
        MatPaginatorModule,
        MatToolbarModule,
        MatProgressSpinnerModule,
        MatSortModule
    ]
})
export class MaterialModule {

}
