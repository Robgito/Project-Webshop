import { Component, OnInit } from '@angular/core';
import { SmartphoneService } from '../services/smartphone.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-show-products',
  templateUrl: './show-products.component.html',
  styleUrl: './show-products.component.css',
})
export class ShowProductsComponent implements OnInit {

  smartphones: any;
  currentPage: number = 1;
  itemsPerPage: number = 9;
  hasMorePages: boolean = true;

  constructor(
    private smartphoneService: SmartphoneService,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.loadSmartPhonesInarray(this.currentPage);
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

  deleteSmartPhoneById(smartphoneId: number) {
    this.smartphoneService.deleteSmartphoneById(smartphoneId).subscribe(
      (response) => {
        alert('Smartphone successfully deleted!!');
        this.ngOnInit();
      },
      (error) => {
        alert('An error has occurred when deleting the product');
        console.log(error);
      }
    );
  }

  updateSmartPhoneById(smartphoneId: number) {
    this.router.navigate([
      '/update-smartphone',
      { smartphoneId: smartphoneId },
    ]);
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

  goToPage(page: number): void {
    this.currentPage = page;
    this.loadSmartPhonesInarray(this.currentPage);
  }


  checkHasMorePages(): void {
    this.smartphoneService.getSmartphones(this.currentPage + 1).subscribe(
      (response) => {
        this.hasMorePages = response.length > 0;
      },
      (error) => {
        this.hasMorePages = false;
      }
    );
  }
}
