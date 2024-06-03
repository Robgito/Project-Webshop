import { Component, OnInit } from '@angular/core';
import { Smartphone } from '../model/smartphone.model';
import { NgForm } from '@angular/forms';
import { SmartphoneService } from '../services/smartphone.service';
import { HttpErrorResponse } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';
import { MessageTypes } from 'jest-editor-support';

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

  constructor(private smartphoneservice: SmartphoneService) { }
  
  ngOnInit(): void {};
 

  addSmartphone(smartphoneForm: NgForm) {
    this.smartphoneservice.addSmartphone(this.phone).subscribe(
      (response: Smartphone) => {
        smartphoneForm.reset();
        alert("Smartphone successfully added!!");
      },
      (error) => {
       alert("An error has occurred when adding the product");
        console.log(error);
      }
    );
  }

}
