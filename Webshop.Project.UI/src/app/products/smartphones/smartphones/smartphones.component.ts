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

  getSmartphonesByFilter(selectedBrand: number|string, selectedCategory: number|string, selectedMemory: number|string, selectedMinPrice: number|string, selectedMaxPrice: number|string, selectedUserSearch: string){
    this.smartphoneService.getSmartphonesByFilter(selectedBrand, selectedCategory, selectedMemory, selectedMinPrice, selectedMaxPrice, selectedUserSearch).subscribe(
      (data) => {
        this.smartphones = data; // Handle the response data as needed
        console.log(this.smartphones);
      },
      (error) => {
        console.error('Error fetching smartphones:', error);
      }
  )}

  selectedBrand: number|string = "";
  selectedCategory: number|string = "";
  selectedMemory: number|string = "";
  selectedMinPrice: number|string = "";
  selectedMaxPrice: number|string = "";
  selectedUserSearch: string = "";

	onSelectedBrand(value: string): void {
    if(value === "0"){
      this.selectedBrand = "";
    }
    else{
      this.selectedBrand = Number(value);
    }

	}

  onSelectedCategory(value: string): void {
    if(value === "0"){
      this.selectedCategory = "";
    }
    else{
      this.selectedCategory = Number(value);
    }

  }

  onSelectedMemory(value: string): void {
    if(value === "0"){
      this.selectedMemory = "";
    }
    else{
      this.selectedMemory = Number(value);
    }
  }

  onSelectedMinPrice(value: string): void {
    if(value === "0"){
      this.selectedMinPrice = "";
    }
    else{
      this.selectedMinPrice = Number(value);
    }
  }

  onSelectedMaxPrice(value: string): void {
    if(value === "0"){
      this.selectedMaxPrice = "";
    }
    else{
      this.selectedMaxPrice = Number(value);
    }
  }

  getSmartphonesBySearch(selectedUserSearch : string){
    this.smartphoneService.getSmartphonesBySearch(selectedUserSearch).subscribe(
      (data) => {
        this.smartphones = data; // Handle the response data as needed
        console.log(this.smartphones);
      },
      (error) => {
        console.error('Error fetching smartphones:', error);
      }
  )}

  onSelectedSearch(value: string): void {
    if(value === ""){
      this.selectedUserSearch = "";
    }
    else{
      this.selectedUserSearch = value;
    }

	}

////Sorting Logic
//_______________
  sortOption: string = "";

  sortSmartphones() {
    if (this.sortOption === '1') { // Alphabetical sort
      this.smartphones.sort((a, b) => a.name.localeCompare(b.name));
    }
    else if (this.sortOption === '2') { // Sort price low-high
    this.smartphones.sort((a, b) => a.price - b.price);
    } 
    else if (this.sortOption === '3') { // Sort price high-low
    this.smartphones.sort((a, b) => b.price - a.price);
  }
  }

  onSortChange(event: Event) {
    const target = event.target as HTMLSelectElement;
    if (target) {
      this.sortOption = target.value;
      this.sortSmartphones();
    }
  }
}