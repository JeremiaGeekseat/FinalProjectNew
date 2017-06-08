import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';

export class Movie {
    constructor(public id: number, public createdDate: Date, public modifiedDate: Date, public isDeleted: boolean, public title: string, public description: string, public viewed: number, public released: Date, public thumbnailUrl: string, public backgroundUrl: string, public category: number, public rate: number) { }
}

export class Rate {
    constructor(public id: number, public rating: number) { }
}

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