import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { SmartphoneService } from '../services/smartphone.service';
import { ActivatedRoute } from '@angular/router';
import { BrandService } from '../services/brand.service';
import { CategoryService } from '../services/category.service';

@Component({
  selector: 'app-update-smartphone',
  templateUrl: './update-smartphone.component.html',
  styleUrl: './update-smartphone.component.css'
})
export class UpdateSmartphoneComponent implements OnInit {

  phone: any;
  brands: any;
  categories: any;


  constructor(private smartphoneservice: SmartphoneService, private brandService: BrandService, private categoryService: CategoryService ,private activatedRoute: ActivatedRoute) { }
  ngOnInit(): void {
    this.phone = this.activatedRoute.snapshot.data['phone'];


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


  updateSmartphone(smartphoneForm: NgForm) {
    this.smartphoneservice.updatesmartphone(this.phone.id, this.phone).subscribe(
      (response) => {
        console.log(response);
        alert("Smartphone successfully updated!!");
        smartphoneForm.reset();
      },
      (error) => {
        alert("An error has occurred when updating the product");
        console.log(error);
      }
    );
  }
}
