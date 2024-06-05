import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Brand } from '../model/smartphone.model';


@Injectable({
  providedIn: 'root'
})
export class BrandService {

  private readonly API_URL = 'https://localhost:7129/api/Brand/GetAllBrands';

  constructor(private httpClient : HttpClient) { }

  getBrands() : Observable<any>{
    return this.httpClient.get(this.API_URL);
  }

  getDetailedBrand(id: any) {
    return this.httpClient.get<Brand>(`https://localhost:7129/api/Brand?id=${id}`);
  }

  addBrand(brand: Brand) {
    return this.httpClient.post<Brand>('https://localhost:7129/api/Brand', brand);
  }

  deleteBrandById(id: number) {
    return this.httpClient.delete(`https://localhost:7129/api/Brand?id=${id}`);
  }

  updateBrand(id: number, brand: Brand) {
    return this.httpClient.put(`https://localhost:7129/api/Brand?id=${id}`, brand);

  }
}

