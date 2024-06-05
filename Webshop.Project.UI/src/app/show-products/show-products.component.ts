import { Component, OnInit } from '@angular/core';
import { SmartphoneService } from '../services/smartphone.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-show-products',
  templateUrl: './show-products.component.html',
  styleUrl: './show-products.component.css'
})
export class ShowProductsComponent implements OnInit {

  smartphones: any[] = [];
  phones: any[] = [];
  totalPages: number = 0;
  currentPage: number = 1;
  itemsPerPage: number = 9;
  constructor(private smartphoneservice: SmartphoneService, private router: Router) {  }

  ngOnInit(): void {
    this.loadSmartphones();
  }

  loadSmartphones(): void {
    this.smartphoneservice.getSmartphonesPerpage(this.currentPage, this.itemsPerPage).subscribe(
      (data: any) => {
        this.smartphones = data;
        this.totalPages = Math.ceil(data.totalItems / this.itemsPerPage);
      },
      (error) => {
        console.error('Error fetching smartphones:', error);
      }
    );
  }

  deleteSmartPhoneById(smartphoneId: number) {
    this.smartphoneservice.deleteSmartphoneById(smartphoneId).subscribe(
      (response) => {
        alert("Smartphone successfully deleted!!");
        this.ngOnInit();       
      },
      (error) => {
        alert("An error has occurred when deleting the product");
        console.log(error);
        
      }
    );
    }

    updateSmartPhoneById(smartphoneId: number) {
      this.router.navigate(['/update-smartphone', {smartphoneId: smartphoneId}]);
    }

    onPageChanged(page: number): void {
      this.currentPage = page;
      this.loadSmartphones();
    }

    getAllphones():void {
      this.smartphoneservice.getSmartphones().subscribe(
        (data: any) => {
          this.phones = data;}
      )
    }

}
