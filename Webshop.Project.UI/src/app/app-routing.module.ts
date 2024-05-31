import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SmartphonesComponent } from './products/smartphones/smartphones/smartphones.component';
import { SmartphoneDetailsComponent } from './products/smartphones/smartphone-details/smartphone-details.component';
import { BasketComponent } from './basket/basket.component';

const routes: Routes = [
  { path: '', component: SmartphonesComponent },
  { path: 'smartphones', component: SmartphonesComponent },
  { path: 'smartphones/:smartphoneId', component: SmartphoneDetailsComponent },
  { path: 'basket', component: BasketComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
