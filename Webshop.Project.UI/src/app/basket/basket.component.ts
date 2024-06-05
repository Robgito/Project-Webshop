import { Component, OnInit } from '@angular/core';
import { RouterLink } from '@angular/router';
import { BasketService } from '../services/basket.service';
import { CurrencyPipe } from '@angular/common';
import { Basket } from '../model/basket';
import { DatePipe } from '@angular/common';
import { BasketProduct } from '../model/smartphone.model';

@Component({
  selector: 'app-basket',
  templateUrl: './basket.component.html',
  styleUrl: './basket.component.css',
})
export class BasketComponent {
  productsInBasket: any[] = [];
  basket: Basket[] = [];
  basketproductSelected: any[] = [];

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

    this.basketService.GetFullBasket(1).subscribe(
      (data) => {
        this.basket[0] = data;
        console.log(this.basket);
      },
      (error) => {
        console.error('Error fetching basket:', error);
      }
    );
  }

  DeleteBasketProductByID(basketproductID: number) {
    this.basketService
      .DeleteBasketProductID(basketproductID)
      .subscribe(() => this.LoadBasket());
  }

  AddAmountToBasketProduct(basketproductID: number) {
    this.basketService
      .AddAmountInBasketByID(basketproductID)
      .subscribe(() => this.LoadBasket());
  }

  DecreaseAmountToBasketProduct(basketproductID: number) {
    this.basketService
      .DecreaseAmountInBasketByID(basketproductID)
      .subscribe(() => this.LoadBasket());
  }

  LoadBasket(): void {
    this.productsInBasket = [];
    this.basketService.GetProductsInBasket(1).subscribe(
      (data) => {
        this.productsInBasket = data;
        console.log(this.productsInBasket);
      },
      (error) => {
        console.error('Error fetching basket products:', error);
      }
    );

    this.basketService.GetFullBasket(1).subscribe(
      (data) => {
        this.basket[0] = data;
        console.log(this.basket);
      },
      (error) => {
        console.error('Error fetching basket:', error);
      }
    );
  }
}
