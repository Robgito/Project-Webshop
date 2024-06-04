import { Component, OnInit } from '@angular/core';
import { SmartphoneService } from '../../../services/smartphone.service';
import { BrandService } from '../../../services/brand.service';
import { CategoryService } from '../../../services/category.service';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-smartphones',
  templateUrl: './smartphones.component.html',
  styleUrl: './smartphones.component.css'
})
export class SmartphonesComponent implements OnInit {
  smartphones : any[] = []
  brands : any[] = []
  categories : any[] = []

  /**
   *
   */
  constructor(
    private smartphoneService : SmartphoneService,
    private brandService : BrandService, 
    private categoryService : CategoryService
  ) {}

  ngOnInit(): void {
    this.smartphoneService.getSmartphones().subscribe(
      (data) => {
        this.smartphones = data; // Handle the response data as needed
        console.log(this.smartphones);
      },
      (error) => {
        console.error('Error fetching smartphones:', error);
      }
    );

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
}
