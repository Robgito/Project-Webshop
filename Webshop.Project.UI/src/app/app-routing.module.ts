import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SmartphonesComponent } from './products/smartphones/smartphones/smartphones.component';
import { SmartphoneDetailsComponent } from './products/smartphones/smartphone-details/smartphone-details.component';
import { AdminComponent } from './admin/admin/admin.component';
import { AddSmartphoneComponent } from './add-smartphone/add-smartphone.component';
import { ShowProductsComponent } from './show-products/show-products.component';

const routes: Routes = [
  { path: '', component: SmartphonesComponent },
  { path: 'smartphones', component: SmartphonesComponent },
  { path: 'admin', component: AdminComponent},
  { path: 'smartphones/:smartphoneId', component: SmartphoneDetailsComponent },
  {path: 'add-smartphone', component: AddSmartphoneComponent},
  {path: 'show-products', component: ShowProductsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
