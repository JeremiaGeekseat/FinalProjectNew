import { Component } from '@angular/core';
import { ActivatedRoute, Router, Params } from '@angular/router';

import { Movie } from '../../data/movie';
import { Script } from '../../services/script.service';
import { MovieService } from '../../services/movie.service';

@Component({
    selector: 'movie-category',
    templateUrl: './movie.category.component.html'
})
export class MovieCategoryComponent {
    errorMessage: string;
    movies: Movie[];
    id: number;
    isLoading: boolean;

    constructor(private movieService: MovieService, private route: ActivatedRoute, private script: Script) { }
    
    getMovies(value: number) {
        this.movieService.getMoviesByCategory(value).then(res => {
            this.movies = res;
            this.getRate();
            this.isLoading = false;
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
        this.isLoading = true;

        this.route.params.subscribe((params: Params) => {
            this.id = params['id'] as number;
        });

        this.getMovies(this.id);
        
        this.script.load('jquery', 'bootstrap', 'easing', 'dotdotdot', 'flexslider', 'magnific', 'slidey', 'move', 'carousel', 'simplePlayer', 'custom').then(data => {
            console.log('script loaded ', data);
        }).catch(error => console.log(error));
    }
}