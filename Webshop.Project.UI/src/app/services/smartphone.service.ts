import { HttpClient, HttpHeaders } from '@angular/common/http';
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


  getDetailedSmartphoneByName(id: number) {
    
    return this.httpClient.get(`https://localhost:7129/api/Smartphone?id=${id}`);

  }


  
}
