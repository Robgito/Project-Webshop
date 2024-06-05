import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, Resolve, RouterStateSnapshot } from '@angular/router';
import { Brand } from '../model/smartphone.model';
import { BrandService } from './brand.service';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BrandResolveService implements Resolve<Brand> {

  constructor(private brandservice: BrandService) { }

  resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Brand> {
    const id: any = route.paramMap.get('brandId');

    if (id) {
      return this.brandservice.getDetailedBrand(id);
    }
    else {
      // returen empty brand
      return of(this.getBrandDetails());
    }
  }

  getBrandDetails() {
    return {
      name: "",
    };
  }
}
