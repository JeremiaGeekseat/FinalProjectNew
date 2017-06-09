import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';

import { Category } from '../data/category';
import { Rate } from '../data/rate';
import { Movie } from '../data/movie';

@Injectable()
export class MovieService {
    constructor(private http: Http) { }

    getMovie(value: number): Promise<Movie> {
        return this.http.get('http://localhost:51402/api/Movies/GetMovie/' + value)
            .toPromise()
            .then(res => res.json() as Movie)
            .catch(this.handleError);
    }

    getMovies(value?: string): Promise<Movie[]> {
        return this.http.get('http://localhost:51402/api/Movies/GetMovies')
            .toPromise()
            .then(res => res.json() as Movie[])
            .catch(this.handleError);
    }

    getMoviesByCategory(value: number): Promise<Movie[]> {
        return this.http.get('http://localhost:51402/api/Movies/GetMoviesByCategory' + value)
            .toPromise()
            .then(res => res.json() as Movie[])
            .catch(this.handleError);
    }

    getMovieCategory(value: number): Promise<Category> {
        return this.http.get('http://localhost:51402/api/Movies/GetMovieCategory/' + value)
            .toPromise()
            .then(res => res.json() as Category);
    }

    getMovieRate(value: number): Promise<Rate> {
        return this.http.get('http://localhost:51402/api/Movies/GetMovieRate/' + value)
            .toPromise()
            .then(res => res.json() as Rate);
    }

    private handleError(error: Response) {
        console.error(error);
        let msg = `Error status code ${error.status} at ${error.url}`;
        return Observable.throw(msg);
    }
}