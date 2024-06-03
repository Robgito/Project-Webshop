import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SmartphonesComponent } from './products/smartphones/smartphones/smartphones.component';
import { SmartphoneDetailsComponent } from './products/smartphones/smartphone-details/smartphone-details.component';
import { AdminComponent } from './admin/admin/admin.component';
import { AddSmartphoneComponent } from './add-smartphone/add-smartphone.component';
import { ShowProductsComponent } from './show-products/show-products.component';
import { BasketComponent } from './basket/basket.component';
import { SignInComponent } from './sign/sign-in/sign-in.component';
import { SignUpComponent } from './sign/sign-up/sign-up.component';
import { CheckoutComponent } from './checkout/checkout.component';
import { SmartphoneResolveService } from './services/smartphone-resolve.service';
import { UpdateSmartphoneComponent } from './update-smartphone/update-smartphone.component';


const routes: Routes = [
  { path: '', component: SmartphonesComponent },
  { path: 'smartphones', component: SmartphonesComponent },
  { path: 'admin', component: AdminComponent},
  { path: 'smartphones/:smartphoneId', component: SmartphoneDetailsComponent },
  { path: 'basket', component: BasketComponent},
  { path: 'signin', component: SignInComponent},
  { path: 'signup', component: SignUpComponent},
  { path: 'checkout', component: CheckoutComponent},
  {path: 'add-smartphone', component: AddSmartphoneComponent },
  {path: 'show-products', component: ShowProductsComponent},
  {path: 'update-smartphone', component: UpdateSmartphoneComponent,resolve: {phone: SmartphoneResolveService}}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
