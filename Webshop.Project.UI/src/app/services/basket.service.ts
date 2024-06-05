import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable, min } from 'rxjs';
import { Smartphone } from '../model/smartphone.model';

@Injectable({
  providedIn: 'root',
})
export class BasketService {
  private readonly API_URL =
    'https://localhost:7129/api/Basket/GetAllProductsInBasket';

  constructor(private httpClient: HttpClient) {}

  GetProductsInBasket(basketID: number): Observable<any> {
    return this.httpClient.get(this.API_URL + `?basketID=${basketID}`);
  }
}
