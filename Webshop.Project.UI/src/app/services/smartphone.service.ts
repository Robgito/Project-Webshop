import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, min } from 'rxjs';
import { Smartphone } from '../model/smartphone.model';
import { BasketProduct } from '../model/smartphone.model';

@Injectable({
  providedIn: 'root',
})
export class SmartphoneService {
  private readonly API_URL =
    'https://localhost:7129/api/Smartphone/GetAllSmartphones';

  constructor(private httpClient: HttpClient) { }

  getSmartphones(page: number = 1): Observable<any> {
    return this.httpClient.get(this.API_URL + `?page=${page}&items=9`);
  }

  getSmartphonesByFilter(
    brandId: number | string,
    categoryId: number | string,
    memoryCapacity: number | string,
    minPrice: number | string,
    maxPrice: number | string
  ): Observable<any> {
    return this.httpClient.get(
      this.API_URL +
      `?enterBrandID=${brandId}&enterCategoryID=${categoryId}&enterMemoryCapacity=${memoryCapacity}&enterMinPrice=${minPrice}&enterMaxPrice=${maxPrice}&page=1&items=20`
    );
  }

  getSmartphoneBySearch(userSearch: number | string): Observable<any> {
    return this.httpClient.get(
      this.API_URL + `?userSearch=${userSearch}&page=1&items=20`
    );
  }

  getDetailedSmartphoneById(id: any) {
    return this.httpClient.get<Smartphone>(
      `https://localhost:7129/api/Smartphone?id=${id}`
    );
  }

  addSmartphone(smartphone: Smartphone) {
    return this.httpClient.post<Smartphone>(
      'https://localhost:7129/api/Smartphone',
      smartphone
    );
  }

  addSmartphoneToBasket(basketProduct: BasketProduct) {
    return this.httpClient.post<BasketProduct>(
      `https://localhost:7129/api/Basket/AddBasketProduct`,
      basketProduct
    );
  }

  deleteSmartphoneById(id: number) {
    return this.httpClient.delete(
      `https://localhost:7129/api/Smartphone?id=${id}`
    );
  }

  updatesmartphone(id: number, smartphone: Smartphone) {
    return this.httpClient.put(
      `https://localhost:7129/api/Smartphone?id=${id}`,
      smartphone
    );
  }
}
