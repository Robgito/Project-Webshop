import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Brand } from '../model/smartphone.model';
import { BrandService } from '../services/brand.service';

@Component({
  selector: 'app-add-brand',
  templateUrl: './add-brand.component.html',
  styleUrl: './add-brand.component.css'
})
export class AddBrandComponent implements OnInit {

  brand: Brand = {
    name: "",
  }

  constructor(private brandservice: BrandService) { }

  ngOnInit(): void { };

  addBrand(brandForm: NgForm) {

    if (brandForm.invalid) {
      return;
    }
    
    this.brandservice.addBrand(this.brand).subscribe(
      (data: Brand) => {
        brandForm.reset();
        alert("Brand successfully added!!");
      },
      (error) => {
        alert("An error has occurred when adding the brand");
        console.log(error);
      }
    );
  }
}
