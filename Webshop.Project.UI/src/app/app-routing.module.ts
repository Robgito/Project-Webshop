import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SmartphonesComponent } from './products/smartphones/smartphones/smartphones.component';
import { SmartphoneDetailsComponent } from './products/smartphones/smartphone-details/smartphone-details.component';
<<<<<<< HEAD
import { AdminComponent } from './admin/admin/admin.component';
import { AddSmartphoneComponent } from './add-smartphone/add-smartphone.component';
import { ShowProductsComponent } from './show-products/show-products.component';
=======
import { BasketComponent } from './basket/basket.component';
>>>>>>> 713b74097f67238c3eb2bab5a96735de0f56949e

const routes: Routes = [
  { path: '', component: SmartphonesComponent },
  { path: 'smartphones', component: SmartphonesComponent },
  { path: 'admin', component: AdminComponent},
  { path: 'smartphones/:smartphoneId', component: SmartphoneDetailsComponent },
<<<<<<< HEAD
  {path: 'add-smartphone', component: AddSmartphoneComponent},
  {path: 'show-products', component: ShowProductsComponent}
=======
  { path: 'basket', component: BasketComponent}
>>>>>>> 713b74097f67238c3eb2bab5a96735de0f56949e
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
