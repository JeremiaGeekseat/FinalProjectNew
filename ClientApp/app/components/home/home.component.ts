import { Component } from '@angular/core';

import { Movie } from '../../data/movie';
import { MovieService } from '../../services/movie.service';

import { Script } from '../../services/script.service';

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {
    errorMessage: string;
    movies: Movie[];

    constructor(private movieService: MovieService, private script: Script) { }
    
    getMovies(value?: string) {
        this.movieService.getMovies(value).then(res => {
            this.movies = res;
            this.getRate();
        })
    }

    getUrl(val: string) {
        return "../../dist/images/" + val;
    }

    getRate() {
        for (let movie of this.movies) {
            this.movieService.getMovieRate(movie.id).then(res => {
                movie.rate = res.rating
            });
        }
    }

    getStar(val: number) {
        let star: string;
        star = "";
        for (let i = 1; i <= 5; i++) {
            if (i <= val) {
                star = star + '<li><a href="#"><i class="fa fa-star" aria-hidden="true"></i></a></li> ';
            } else {
                star = star + '<li><a href="#"><i class="fa fa-star-o" aria-hidden="true"></i></a></li> ';
            }
        }
        return star;
    }

    ngOnInit() {
        this.getMovies();
        //this.script.load('jquery', 'bootstrap', 'easing', 'dotdotdot', 'flexslider', 'magnific', 'slidey', 'move', 'carousel', 'simplePlayer', 'custom').then(data => {
        //    console.log('script loaded ', data);
        //}).catch(error => console.log(error));
    }
}