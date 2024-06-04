import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  private readonly API_URL = 'https://localhost:7129/api/Category/GetAllCategories';

  constructor(private httpClient : HttpClient) { }

  getCategories() : Observable<any>{
    return this.httpClient.get(this.API_URL);
  }


  getDetailedCategoryByName(id: number) {
    
    return this.httpClient.get(`https://localhost:7129/api/Category?id=${id}`);

  }

}
