import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Smartphone } from '../model/smartphone.model';

@Injectable({
  providedIn: 'root'
})
export class SmartphoneService {
  

  private API_URL = 'https://localhost:7129/api/Smartphone/GetAllSmartphones';

  constructor(private httpClient : HttpClient) { }

  getSmartphones() : Observable<any>{
    return this.httpClient.get(this.API_URL);
  }


  getDetailedSmartphoneById(id: any) {
    return this.httpClient.get<Smartphone>(`https://localhost:7129/api/Smartphone?id=${id}`);
  }

  addSmartphone(smartphone: Smartphone) {
    return this.httpClient.post<Smartphone>("https://localhost:7129/api/Smartphone", smartphone);
  }

  deleteSmartphoneById(id: number) {
    return this.httpClient.delete(`https://localhost:7129/api/Smartphone?id=${id}`);
  }

  

 



  
}
