import { Component, OnInit } from '@angular/core';
import { RouterLink } from '@angular/router';
import { BasketService } from '../services/basket.service';
import { CurrencyPipe } from '@angular/common';

@Component({
  selector: 'app-basket',
  templateUrl: './basket.component.html',
  styleUrl: './basket.component.css',
})
export class BasketComponent {
  productsInBasket: any[] = [];

  constructor(private basketService: BasketService) {}

  ngOnInit(): void {
    this.basketService.GetProductsInBasket(1).subscribe(
      (data) => {
        this.productsInBasket = data;
        console.log(this.productsInBasket);
      },
      (error) => {
        console.error('Error fetching basket products:', error);
      }
    );
  }
}
