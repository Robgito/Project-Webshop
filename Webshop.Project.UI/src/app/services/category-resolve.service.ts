import { Injectable } from '@angular/core';
import { CategoryService } from './category.service';
import { ActivatedRouteSnapshot, Resolve, RouterStateSnapshot } from '@angular/router';
import { Category } from '../model/smartphone.model';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CategoryResolveService implements Resolve<Category> {
  constructor(private categoryservice: CategoryService) { }

  resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Category> {
    const id: any = route.paramMap.get('categoryId');

    if (id) {
      return this.categoryservice.getDetailedCategoryById(id);
    }
    else {
      // returen empty brand
      return of(this.getCategoryDetails());
    }
  }

  getCategoryDetails() {
    return {
      name: "",
    };
  }
}
