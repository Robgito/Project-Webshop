import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SmartphoneService {

  private API_URL = 'https://localhost:7129/api/Smartphone/GetAllSmartphones';
  private Key = 'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJqdGkiOiIyOWQ1YmY4My1kNThmLTQyMTMtODY2Yy00MmFiMmI1OWIxNzYiLCJlbWFpbCI6ImZvb0BiYXIuY29tIiwibmFtZSI6IkpvcyBkZSBtYWdhemlqbmllciIsInVzZXJJZCI6Ii0xIiwicm9sZSI6IkFkbWluIiwibmJmIjoxNzE1OTQzNzE1LCJleHAiOjE3MTU5NDczMTUsImlhdCI6MTcxNTk0MzcxNSwiaXNzIjoiaHR0cDovL2xvY2FsaG9zdDo1MTYyLyIsImF1ZCI6Imh0dHA6Ly9sb2NhbGhvc3Q6NTE2Mi8ifQ.PK5GoAGKopqYt8O1RbltIbuOQWLB_Y4t0bh461iGi_c';

  getSmartphones() : Observable<any>{

    const headers = new HttpHeaders({
      Authorization: `bearer ${this.Key}`
    });
    return this.httpClient.get(this.API_URL, {headers});

  }

  constructor(private httpClient : HttpClient) { }
}
