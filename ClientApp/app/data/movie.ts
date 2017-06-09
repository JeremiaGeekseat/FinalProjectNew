import { Injectable } from '@angular/core';

export class Movie {
    constructor(public id: number, public createdDate: Date, public modifiedDate: Date, public isDeleted: boolean, public title: string, public description: string, public viewed: number, public released: Date, public thumbnailUrl: string, public backgroundUrl: string, public categoryId: number, public rate: number) { }
}