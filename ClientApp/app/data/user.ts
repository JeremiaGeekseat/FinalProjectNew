import { Injectable } from '@angular/core';

export class User {
    constructor(
        public id: number,
        public createdDate: Date,
        public modifiedDate: Date,
        public isDeleted: boolean,
        public name: string,
        public isAdmin: boolean,
        public email: string,
        public password: string,
        public phone: string,
        public isActivated: boolean) { }
}