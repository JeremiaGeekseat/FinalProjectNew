import { Injectable } from '@angular/core';
import { Http, Response, Headers } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';


import { Category } from '../data/category';

@Injectable()
export class CategoryService {
    constructor(private http: Http) { }

    getCategories(): Promise<Category[]> {
        return this.http.get('http://localhost:51402/api/Categories/GetCategories')
            .toPromise()
            .then(res => res.json() as Category[])
            .catch(this.handleError);
    }

    private handleError(error: Response) {
        console.error(error);
        let msg = `Error status code ${error.status} at ${error.url}`;
        return Observable.throw(msg);
    }
}