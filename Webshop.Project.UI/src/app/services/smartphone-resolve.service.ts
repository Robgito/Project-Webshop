import { Injectable } from '@angular/core';
import {
  ActivatedRouteSnapshot,
  Resolve,
  RouterStateSnapshot,
} from '@angular/router';
import { Observable, of } from 'rxjs';
import { Smartphone } from '../model/smartphone.model';
import { SmartphoneService } from './smartphone.service';

@Injectable({
  providedIn: 'root',
})
export class SmartphoneResolveService implements Resolve<Smartphone> {
  constructor(private smartphoneservice: SmartphoneService) { }

  resolve(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot
  ): Observable<Smartphone> {
    const id: any = route.paramMap.get('smartphoneId');

    if (id) {
      // Call API to fetch smartphone details from backend
      return this.smartphoneservice.getDetailedSmartphoneById(id);
    } else {
      // returen empty smartphone observable
      return of(this.getSmartphoneDetails());
    }
  }

  getSmartphoneDetails() {
    return {
      id: 0,
      name: '',
      description: '',
      price: 0,
      image: '',
      stock: 0,
      memoryCapacity: 0,
      colour: '',
      screenSize: 0,
      brandID: 0,
      categoryID: 0,
    };
  }
}
