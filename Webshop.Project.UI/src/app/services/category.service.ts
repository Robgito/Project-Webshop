import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Category } from '../model/smartphone.model';


@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  private readonly API_URL = 'https://localhost:7129/api/Category/GetAllCategories';

  constructor(private httpClient : HttpClient) { }

  getCategories() : Observable<any>{
    return this.httpClient.get(this.API_URL);
  }

  getDetailedCategoryById(id: any) {
    return this.httpClient.get<Category>(`https://localhost:7129/api/Category/GetCategory?id=${id}`);
  }

  addCategory(category: Category) {
    return this.httpClient.post<Category>('https://localhost:7129/api/Category/AddCategory', category);
  }

  deleteCategoriesById(id: number) {
    return this.httpClient.delete(`https://localhost:7129/api/Category/DeleteCategory?id=${id}`);
  }

  updateCategory(id: number, category: Category) {
    return this.httpClient.put(`https://localhost:7129/api/Category/UpdateCategory?id=${id}`, category);

  }
}
