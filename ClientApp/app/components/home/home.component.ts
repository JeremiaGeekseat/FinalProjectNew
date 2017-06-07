import { Component } from '@angular/core';

import { Movie, MovieService } from '../../services/movie.service';


@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {
    errorMessage: string;
    movies: Movie[];

    constructor(private movieService: MovieService) { }

    getMovies(value?: string) {
        this.movieService.getMovies(value).then(res => {
            this.movies = res;
        })
    }

    getUrl(val: string) {
        return "../../dist/images/" + val;
    }

    //getRate(value?: string) {
    //    this.movieService.getMovieRate(value).then(res => {
    //        this.rates = res;
    //    })
    //}

    ngOnInit() { this.getMovies(); }
}