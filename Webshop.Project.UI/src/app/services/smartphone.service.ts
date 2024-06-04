import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SmartphoneService {
  

  private readonly API_URL = 'https://localhost:7129/api/Smartphone/GetAllSmartphones';

  constructor(private httpClient : HttpClient) { }

  getSmartphones() : Observable<any>{

    return this.httpClient.get(this.API_URL);

  }

  getSmartphonesByFilter(brandId: number|string, categoryId: number|string, memoryCapacity: number|string, minPrice: number|string, maxPrice: number|string) : Observable<any>{

    return this.httpClient.get(this.API_URL  + `?enterBrandID=${brandId}&enterCategoryID=${categoryId}&enterMemoryCapacity=${memoryCapacity}&enterMinPrice=${minPrice}&enterMaxPrice=${maxPrice}&page=1&items=20`);

  }

  getDetailedSmartphoneByName(id: number) {
    
    return this.httpClient.get(`https://localhost:7129/api/Smartphone?id=${id}`);

  }

}