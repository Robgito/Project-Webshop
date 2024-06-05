import { Component, OnInit } from '@angular/core';
import { Smartphone } from '../model/smartphone.model';
import { NgForm } from '@angular/forms';
import { SmartphoneService } from '../services/smartphone.service';
import { BrandService } from '../services/brand.service';
import { CategoryService } from '../services/category.service';

@Component({
  selector: 'app-add-smartphone',
  templateUrl: './add-smartphone.component.html',
  styleUrl: './add-smartphone.component.css',
})
export class AddSmartphoneComponent implements OnInit {

  brands: any;
  categories: any;

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
    brandID: 0,
    categoryID: 0
  }



  constructor(private smartphoneservice: SmartphoneService, private brandService: BrandService, private categoryService: CategoryService) { }

  ngOnInit(): void {
    this.brandService.getBrands().subscribe(
      (data) => {
        this.brands = data;
        console.log(this.brands);
      },
      (error) => {
        console.error('Error fetching brands:', error);
      }
    );
    this.categoryService.getCategories().subscribe(
      (data) => {
        this.categories = data;
        console.log(this.categories);
      },
      (error) => {
        console.error('Error fetching categories:', error);
      }
    );
  }

  addSmartphone(smartphoneForm: NgForm) {

    if (smartphoneForm.invalid) {
      return;
    }

    this.smartphoneservice.addSmartphone(this.phone).subscribe(
      (response: Smartphone) => {
        smartphoneForm.reset();
        alert('Smartphone successfully added!!');
      },
      (error) => {
        alert("An error has occurred when adding the product");
        console.log(error);
      }
    );
  }
}
