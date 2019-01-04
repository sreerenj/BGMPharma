import { NgModule } from '@angular/core';
import { CdkTableModule } from '@angular/cdk/table';

import {
    MatButtonModule,
    MatSlideToggleModule,
    MatPaginatorModule,
    MatTableModule,
    MatToolbarModule,
    MatProgressSpinnerModule,
    MatSortModule,
    MatInputModule,
    MatGridListModule,
    MatFormFieldModule
} from '@angular/material';
@NgModule({
    imports: [
        MatButtonModule,
        MatSlideToggleModule,
        MatPaginatorModule,
        MatTableModule,
        MatToolbarModule,
        MatProgressSpinnerModule,
        MatSortModule,
        MatInputModule,
        MatGridListModule,
        MatFormFieldModule
    ],
    exports: [
        CdkTableModule,
        MatButtonModule,
        MatSlideToggleModule,
        MatTableModule,
        MatPaginatorModule,
        MatToolbarModule,
        MatProgressSpinnerModule,
        MatSortModule,
        MatInputModule,
        MatGridListModule,
        MatFormFieldModule
    ]
})
export class MaterialModule {

}
