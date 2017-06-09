import { Injectable } from '@angular/core';

export class Category {
    constructor(public id: number, public createdDate: Date, public modifiedDate: Date, public isDeleted: boolean, public name: string) { }
}