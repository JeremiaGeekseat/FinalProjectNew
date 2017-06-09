import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { FooterComponent } from './components/footer/footer.component';
import { HomeComponent } from './components/home/home.component';
import { MovieDetailComponent } from './components/movie-detail/movie.detail.component';

import { MovieService } from './services/movie.service';
import { Script } from './services/script.service';

export const sharedConfig: NgModule = {
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,
        NavMenuComponent,
        FooterComponent,
        //HomeComponent
        HomeComponent,
        MovieDetailComponent
    ],
    imports: [
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'movDetail/:id', component: MovieDetailComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ],
    providers: [MovieService, Script]
};
