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
            this.getRate();
        })
    }

    getUrl(val: string) {
        return "../../dist/images/" + val;
    }

    getRate() {
        for (let movie of this.movies) {
            console.log(movie);
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

    ngOnInit() { this.getMovies(); }
}