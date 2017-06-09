import { Injectable } from '@angular/core';
import { Http, Response, Headers } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';


import { User } from '../data/user';

@Injectable()
export class UserService {
    constructor(private http: Http) { }

    register(value: User): Promise<User> {
        return this.http.post('http://localhost:51402/api/Users/Register/', value, { headers: new Headers({ 'Content-Type': 'application/json' }) })
            .toPromise()
            .then(() => value)
            .catch(this.handleError);
    }

    private handleError(error: Response) {
        console.error(error);
        let msg = `Error status code ${error.status} at ${error.url}`;
        return Observable.throw(msg);
    }
}