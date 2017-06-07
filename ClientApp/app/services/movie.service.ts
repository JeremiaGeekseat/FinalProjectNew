import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';

export class Movie {
    constructor(public ID: number, public Title: string, public Rating: number, public Viewed: number, public Released: Date, public Url: string, public BackgroundUrl: string) { }
}

@Injectable()
export class MovieService {
    constructor(private http: Http) { }

    getMovies(value?: string): Promise<Movie[]> {
        return this.http.get('http://localhost:56364/api/Movies/GetLatestMovies')
            .toPromise()
            .then(res => res.json() as Movie[])
            .catch(this.handleError);
    }

    private handleError(error: Response) {
        console.error(error);
        let msg = `Error status code ${error.status} at ${error.url}`;
        return Observable.throw(msg);
    }
}