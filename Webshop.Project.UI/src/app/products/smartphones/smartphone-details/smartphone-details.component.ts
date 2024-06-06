import { Component } from '@angular/core';
import { SmartphoneService } from '../../../services/smartphone.service';
import { ActivatedRoute } from '@angular/router';
import { Smartphone } from '../../../model/smartphone.model';
import { BasketProduct } from '../../../model/smartphone.model';
import { CurrencyPipe } from '@angular/common';

@Component({
  selector: 'app-smartphone-details',
  templateUrl: './smartphone-details.component.html',
  styleUrl: './smartphone-details.component.css',
})
export class SmartphoneDetailsComponent {
  smartphone: any;

  constructor(
    private smartphoneService: SmartphoneService,
    private route: ActivatedRoute
  ) {
    this.route.params.subscribe((params) => {
      const phoneId = params['smartphoneId'];
      this.smartphoneService
        .getDetailedSmartphoneById(phoneId)
        .subscribe((data) => {
          this.smartphone = data;
          console.log(data);
        });
    });
  }

  addSmartphoneToCart(smartphone: Smartphone) {
    const basketProduct: BasketProduct = {
      productID: smartphone.id,
      basketId: 1,
      amount: 1,
    };

    this.smartphoneService.addSmartphoneToBasket(basketProduct).subscribe();
    alert(`Added ${smartphone.name} to cart!`);
  }
}
