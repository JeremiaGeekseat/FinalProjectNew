import { Component } from '@angular/core';
import { ActivatedRoute, Router, Params } from '@angular/router';

import { Movie } from '../../data/movie';
import { Category } from '../../data/category';
import { MovieService } from '../../services/movie.service';

@Component({
    selector: 'movie-detail',
    templateUrl: './movie.detail.component.html'
})
export class MovieDetailComponent {
    errorMessage: string;
    movies: Movie[];
    id: number;
    selectedMovie: Movie;
    category: Category;
    isLoading: boolean;

    constructor(private movieService: MovieService, private route: ActivatedRoute) { }

    getCategory(value: number) {
        this.movieService.getMovieCategory(value).then(res => {
            this.category = res;
        })
    }

    getMovie(value: number) {
        this.isLoading = true;
        this.movieService.getMovie(value).then(res => {
            this.selectedMovie = res;
            this.getRate();
            this.getCategory(res.id);
            this.isLoading = false;
        })
    }

    getMovies(value?: string) {
        this.movieService.getMovies(value).then(res => {
            this.movies = res;
            this.getRate();
        })
    }

    getRate() {
        this.movieService.getMovieRate(this.id).then(res => {
            this.selectedMovie.rate = res.rating
        });
    }

    getUrl(val: string) {
        return "../../dist/images/" + val;
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
        this.route.params.subscribe((params: Params) => {
            this.id = params['id'] as number;
        });

        this.getMovie(this.id);

        this.getMovies();
    }
}