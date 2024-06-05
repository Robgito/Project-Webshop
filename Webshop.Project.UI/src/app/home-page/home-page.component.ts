import { Component } from '@angular/core';
import { SmartphoneService } from '../services/smartphone.service';
import { Smartphone } from '../model/smartphone.model';
import { BasketProduct } from '../model/smartphone.model';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.css',
})
export class HomePageComponent {
  smartphones: any[] = [];

  /**
   *
   */
  constructor(private smartphoneService: SmartphoneService) {}
  ngOnInit(): void {
    this.smartphoneService.getSmartphones().subscribe(
      (data) => {
        this.smartphones = data.slice(0, 4); // Limit to first 4 smartphones
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
}
