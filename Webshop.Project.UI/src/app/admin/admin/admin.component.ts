import { Component, OnInit } from '@angular/core';
import { Smartphone } from '../../model/smartphone.model';
import { NgForm } from '@angular/forms';
import { SmartphoneService } from '../../services/smartphone.service';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrl: './admin.component.css',
})
export class AdminComponent implements OnInit {
  phone: Smartphone = {
    id: 0,
    name: '',
    description: '',
    price: 0,
    image: '',
    stock: 0,
    memoryCapacity: 0,
    colour: '',
    screenSize: 0,
    brandID: 1,
    categoryID: 1,
  };
  smartphones: any;
  constructor(private smartphoneservice: SmartphoneService) { }

  addSmartphone(smartphoneForm: NgForm) {
    this.smartphoneservice.addSmartphone(this.phone).subscribe(
      (response: Smartphone) => {
        this.ngOnInit();
        smartphoneForm.reset();
      },
      (error: HttpErrorResponse) => {
        console.log(error);
      }
    );
  }

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

  updateSmartPhoneById(smartphoneId: number) { }
}
