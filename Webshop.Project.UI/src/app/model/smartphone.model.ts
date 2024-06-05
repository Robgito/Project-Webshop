export interface Smartphone {
  id: number;
  name: string;
  description: string;
  price: number;
  image: string;
  stock: number;
  memoryCapacity: number;
  colour: string;
  screenSize: number;
  brandID: number;
  categoryID: number;
}

export interface Brand {
  name: string;
}

export interface Category {
  name: string;
}

export interface BasketProduct {
  productID: number;
  basketId: number;
  amount: number;
}
