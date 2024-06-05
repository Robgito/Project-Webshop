import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable, min } from 'rxjs';
import { BasketProduct, Smartphone } from '../model/smartphone.model';
import { BasketComponent } from '../basket/basket.component';

@Injectable({
  providedIn: 'root',
})
export class BasketService {
  private readonly API_URL_PRODUCTS =
    'https://localhost:7129/api/Basket/GetAllProductsInBasket';
  private readonly API_URL_BASKET = 'https://localhost:7129/api/';
  private readonly API_DELETE_BASKETPRODUCT =
    'https://localhost:7129/api/Basket/DeleteBasketProduct';
  private readonly API_GET_BASKETPRODUCT =
    'https://localhost:7129/api/Basket/GetBasketProductByProductAndBasketID';
  private readonly API_ADD_AMOUNT_IN_BASKET =
    'https://localhost:7129/api/Basket/AddAmountToBasketProduct';
  private readonly API_DECREASE_AMOUNT_IN_BASKET =
    'https://localhost:7129/api/Basket/DecreaseAmountToBasketProduct';

  constructor(private httpClient: HttpClient) {}

  GetProductsInBasket(basketID: number): Observable<any> {
    return this.httpClient.get(this.API_URL_PRODUCTS + `?basketID=${basketID}`);
  }

  GetFullBasket(basketID: number): Observable<any> {
    return this.httpClient.get(this.API_URL_BASKET + `Basket?id=${basketID}`);
  }

  GetBasketProductByProductIDAndBasketID(basketId: number, productId: number) {
    return this.httpClient.get(
      this.API_GET_BASKETPRODUCT +
        `?productID=${productId}&basketID=${basketId}`
    );
  }

  DeleteBasketProductID(basketProductID: number) {
    return this.httpClient.delete(
      this.API_DELETE_BASKETPRODUCT + `?id=${basketProductID}`
    );
  }

  AddAmountInBasketByID(basketProductID: number) {
    const body: any[] = [];

    return this.httpClient.patch(
      this.API_ADD_AMOUNT_IN_BASKET + `?id=${basketProductID}`,
      body
    );
  }

  DecreaseAmountInBasketByID(basketProductID: number) {
    const body: any[] = [];

    return this.httpClient.patch(
      this.API_DECREASE_AMOUNT_IN_BASKET + `?id=${basketProductID}`,
      body
    );
  }
}
