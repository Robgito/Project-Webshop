import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SmartphoneService {

  private API_URL = 'https://localhost:7129/api/Smartphone/GetAllSmartphones';


  getSmartphones() : Observable<any>{
    return this.httpClient.get(this.API_URL);
  }

  constructor(private httpClient : HttpClient) { }
}
