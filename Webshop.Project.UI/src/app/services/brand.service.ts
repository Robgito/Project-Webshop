import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BrandService {

  private readonly API_URL = 'https://localhost:7129/api/Brand/GetAllBrands';

  constructor(private httpClient : HttpClient) { }

  getBrands() : Observable<any>{
    return this.httpClient.get(this.API_URL);
  }


  getDetailedBrandByName(id: number) {
    
    return this.httpClient.get(`https://localhost:7129/api/Brand?id=${id}`);

  }

}
