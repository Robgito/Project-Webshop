import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SmartphonesComponent } from './products/smartphones/smartphones/smartphones.component';
import { SmartphoneDetailsComponent } from './products/smartphones/smartphone-details/smartphone-details.component';
import { AdminComponent } from './admin/admin/admin.component';
import { AddSmartphoneComponent } from './add-smartphone/add-smartphone.component';
import { ShowProductsComponent } from './show-products/show-products.component';
import { BasketComponent } from './basket/basket.component';
import { SmartphoneResolveService } from './services/smartphone-resolve.service';


const routes: Routes = [
  { path: '', component: SmartphonesComponent },
  { path: 'smartphones', component: SmartphonesComponent },
  { path: 'admin', component: AdminComponent},
  { path: 'smartphones/:smartphoneId', component: SmartphoneDetailsComponent },
  {path: 'add-smartphone', component: AddSmartphoneComponent, resolve: {phone: SmartphoneResolveService}},
  {path: 'show-products', component: ShowProductsComponent},
  { path: 'basket', component: BasketComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
