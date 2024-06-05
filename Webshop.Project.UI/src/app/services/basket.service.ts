import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable, min } from 'rxjs';
import { Smartphone } from '../model/smartphone.model';

@Injectable({
  providedIn: 'root',
})
export class BasketService {
  private readonly API_URL_PRODUCTS =
    'https://localhost:7129/api/Basket/GetAllProductsInBasket';
  private readonly API_URL_BASKET = 'https://localhost:7129/api/';
  private readonly API_DELETE_BASKETPRODUCT =
    'https://localhost:7129/api/Basket/DeleteBasketProduct';

  constructor(private httpClient: HttpClient) {}

  GetProductsInBasket(basketID: number): Observable<any> {
    return this.httpClient.get(this.API_URL_PRODUCTS + `?basketID=${basketID}`);
  }

  GetFullBasket(basketID: number): Observable<any> {
    return this.httpClient.get(this.API_URL_BASKET + `Basket?id=${basketID}`);
  }

  DeleteBasketProduct(basketProductID: number): void {
    this.httpClient.delete(
      this.API_DELETE_BASKETPRODUCT + `?id=${basketProductID}`
    );
  }
}
