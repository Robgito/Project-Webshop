import { Component, OnInit } from '@angular/core';
import { Smartphone } from '../model/smartphone.model';
import { NgForm } from '@angular/forms';
import { SmartphoneService } from '../services/smartphone.service';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-show-products',
  templateUrl: './show-products.component.html',
  styleUrl: './show-products.component.css'
})
export class ShowProductsComponent implements OnInit {

  smartphones: any;
  constructor(private smartphoneservice: SmartphoneService) { }

  ngOnInit(): void {
    this.smartphoneservice.getSmartphones().subscribe(
      (data) => {
        this.smartphones = data; // Handle the response data as needed
        console.log(this.smartphones);
      },
      (error) => {
        console.error('Error fetching smartphones:', error);
      }
    );
  }

  deleteSmartPhoneById(smartphoneId: number) {
    this.smartphoneservice.deleteSmartphoneById(smartphoneId).subscribe(
      (response) => {
        this.ngOnInit();
      },
      (error: HttpErrorResponse) => {
        console.log(error);
      }
    );
    }

    updateSmartPhoneById(smartphoneId: number) {
      
    }

}
