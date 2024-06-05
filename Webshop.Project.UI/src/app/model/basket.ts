export interface Basket {
  id: number;
  totalPrice: number;
  shippingPrice: number;
  expectedShippingDate: Date;
  priceWithShipping: number;
  listProducts: any[];
}
