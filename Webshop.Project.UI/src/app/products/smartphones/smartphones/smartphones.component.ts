import { Component, OnInit } from '@angular/core';
import { SmartphoneService } from '../../../services/smartphone.service';
import { BrandService } from '../../../services/brand.service';
import { CategoryService } from '../../../services/category.service';
import { RouterLink } from '@angular/router';
import { Smartphone } from '../../../model/smartphone.model';
import { BasketProduct } from '../../../model/smartphone.model';

@Component({
  selector: 'app-smartphones',
  templateUrl: './smartphones.component.html',
  styleUrl: './smartphones.component.css',
})
export class SmartphonesComponent implements OnInit {
  smartphones: any[] = [];
  brands: any[] = [];
  categories: any[] = [];
  currentPage: number = 1;
  itemsPerPage: number = 9;
  hasMorePages: boolean = true;

  /**
   *
   */
  constructor(
    private smartphoneService: SmartphoneService,
    private brandService: BrandService,
    private categoryService: CategoryService


  ) { }

  ngOnInit(): void {
    this.smartphoneService.getSmartphones(this.currentPage).subscribe(
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
  
  loadSmartPhonesInarray(currentpage: number) {
    this.smartphoneService.getSmartphones(currentpage).subscribe(
      (data) => {
        this.smartphones = data; // Handle the response data as needed
        console.log(this.smartphones);
      },
      (error) => {
        console.error('Error fetching smartphones:', error);
      }
    );
    this.checkHasMorePages();
  }


  getSmartphonesByFilter(
    selectedBrand: number | string,
    selectedCategory: number | string,
    selectedMemory: number | string,
    selectedMinPrice: number | string,
    selectedMaxPrice: number | string
  ) {
    this.smartphoneService
      .getSmartphonesByFilter(
        selectedBrand,
        selectedCategory,
        selectedMemory,
        selectedMinPrice,
        selectedMaxPrice
      )
      .subscribe(
        (data) => {
          this.smartphones = data; // Handle the response data as needed
          console.log(this.smartphones);
        },
        (error) => {
          console.error('Error fetching smartphones:', error);
        }
      );
  }

  addSmartphoneToCart(smartphone: Smartphone) {
    const basketProduct: BasketProduct = {
      productID: smartphone.id,
      basketId: 1,
      amount: 1,
    };

    this.smartphoneService.addSmartphoneToBasket(basketProduct).subscribe();
  }

  selectedBrand: number | string = '';
  selectedCategory: number | string = '';
  selectedMemory: number | string = '';
  selectedMinPrice: number | string = '';
  selectedMaxPrice: number | string = '';

  onSelectedBrand(value: string): void {
    if (value === '0') {
      this.selectedBrand = '';
    } else {
      this.selectedBrand = Number(value);
    }
  }

  onSelectedCategory(value: string): void {
    if (value === '0') {
      this.selectedCategory = '';
    } else {
      this.selectedCategory = Number(value);
    }
  }

  onSelectedMemory(value: string): void {
    if (value === '0') {
      this.selectedMemory = '';
    } else {
      this.selectedMemory = Number(value);
    }
  }

  onSelectedMinPrice(value: string): void {
    if (value === '0') {
      this.selectedMinPrice = '';
    } else {
      this.selectedMinPrice = Number(value);
    }
  }

  onSelectedMaxPrice(value: string): void {
    if (value === '0') {
      this.selectedMaxPrice = '';
    } else {
      this.selectedMaxPrice = Number(value);
    }
  }

  nextPage(): void {
    if (this.hasMorePages) {
      this.currentPage++;
      this.loadSmartPhonesInarray(this.currentPage);
    }

  }

  previousPage(): void {
    if (this.currentPage > 1) {
      this.currentPage--;
      this.loadSmartPhonesInarray(this.currentPage);
    }
  }
  checkHasMorePages(): void {
    this.smartphoneService.getSmartphones(this.currentPage + 1).subscribe(response => {
      this.hasMorePages = response.length > 0;
    }, error => {
      this.hasMorePages = false;
    });
  }

}
