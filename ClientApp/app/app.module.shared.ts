import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms'

import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { FooterComponent } from './components/footer/footer.component';
import { HomeComponent } from './components/home/home.component';
import { MovieDetailComponent } from './components/movie-detail/movie.detail.component';
import { LoginRegisterComponent } from './components/login-register/login.register.component';
import { MovieCategoryComponent } from './components/movie-category/movie.category.component';

import { CategoryService } from './services/category.service';
import { UserService } from './services/user.service';
import { MovieService } from './services/movie.service';
import { Script } from './services/script.service';

export const sharedConfig: NgModule = {
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,
        NavMenuComponent,
        FooterComponent,
        LoginRegisterComponent,
        HomeComponent,
        MovieDetailComponent,
        MovieCategoryComponent
    ],
    imports: [
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'movDetail/:id', component: MovieDetailComponent },
            { path: 'category/:id', component: MovieCategoryComponent },
            { path: '**', redirectTo: 'home' }
        ]),
        FormsModule
    ],
    providers: [MovieService, UserService, CategoryService, Script]
};
