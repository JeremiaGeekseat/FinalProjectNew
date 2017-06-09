import { Component } from '@angular/core';
import { Category } from '../../data/category';

import { CategoryService } from '../../services/category.service';

@Component({
    selector: 'nav-menu',
    templateUrl: './navmenu.component.html'
})
export class NavMenuComponent {
    errorMessage: string;
    categories: Category[];

    constructor(private categoryService: CategoryService) { }

    getCategories() {
        this.categoryService.getCategories().then(res => {
            this.categories = res;
        })
    }

    ngOnInit() {
        this.getCategories();
    }
}
