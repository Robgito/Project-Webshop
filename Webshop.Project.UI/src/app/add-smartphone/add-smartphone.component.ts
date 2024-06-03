import { Component, OnInit } from '@angular/core';
import { Smartphone } from '../model/smartphone.model';
import { NgForm } from '@angular/forms';
import { SmartphoneService } from '../services/smartphone.service';
import { HttpErrorResponse } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-add-smartphone',
  templateUrl: './add-smartphone.component.html',
  styleUrl: './add-smartphone.component.css'
})
export class AddSmartphoneComponent implements OnInit {

  phone: Smartphone = {
    name: "",
    description: "",
    price: 0,
    image: "",
    stock: 0,
    memoryCapacity: 0,
    colour: "",
    screenSize: 0,
    brandID: 1,
    categoryID: 1
  };

  constructor(private smartphoneservice: SmartphoneService, private activatedRoute: ActivatedRoute) { }
  
  
  ngOnInit(): void {
   this.phone = this.activatedRoute.snapshot.data['phone'];
  }

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

}
