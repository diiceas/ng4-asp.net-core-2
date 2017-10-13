import * as Raven from 'raven-js'

import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { NgModule, NgZone, ErrorHandler } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ToastyModule } from 'ng2-toasty'

import { VehicleService } from './services/vehicle.service';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { VehicleFormComponent } from './components/vehicle-form/vehicle-form.component';
import { AppErrorHandler } from './app.error.handler';

Raven.config("https://b62620db245c47daa9a7d4f3e4b56b91@sentry.io/225623").install();

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        FetchDataComponent,
        HomeComponent,
        VehicleFormComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        ToastyModule.forRoot(),
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'vehicles/new', component: VehicleFormComponent },
            { path: 'home', component: HomeComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ],
    providers: [        
        VehicleService, 
        { provide: ErrorHandler, useClass: AppErrorHandler }
    ]    
})
export class AppModuleShared {
}
