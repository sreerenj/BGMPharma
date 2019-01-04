import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { MaterialModule } from './modules/material.module';
import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { BrowserModule } from '@angular/platform-browser';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import { ManufacturerComponent } from './components/manufacturer/manufacturer.component';
import { ManufacturerListComponent } from './components/manufacturer/manufacturer-list.component';
import { ManufacturerService } from './shared/manufacturer.service';
@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,

        ManufacturerComponent,
        ManufacturerListComponent,
    ],
    imports: [
        CommonModule,
        HttpModule,
        HttpClientModule,
        FormsModule,
        MaterialModule,
        NoopAnimationsModule,
        ReactiveFormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'manufacturers', component: ManufacturerListComponent },
            { path: 'manufacturer', component:ManufacturerComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ],
    providers: [ManufacturerService]
})
export class AppModuleShared {
}
