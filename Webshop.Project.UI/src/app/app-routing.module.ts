import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SmartphonesComponent } from './products/smartphones/smartphones/smartphones.component';
import { SmartphoneDetailsComponent } from './products/smartphones/smartphone-details/smartphone-details.component';
import { BasketComponent } from './basket/basket.component';
import { SignInComponent } from './sign/sign-in/sign-in.component';
import { SignUpComponent } from './sign/sign-up/sign-up.component';
import { CheckoutComponent } from './checkout/checkout.component';
import { HomePageComponent } from './home-page/home-page.component';

const routes: Routes = [
  { path: '', component: HomePageComponent },
  { path: 'smartphones', component: SmartphonesComponent },
  { path: 'smartphones/:smartphoneId', component: SmartphoneDetailsComponent },
  { path: 'basket', component: BasketComponent},
  { path: 'signin', component: SignInComponent},
  { path: 'signup', component: SignUpComponent},
  { path: 'checkout', component: CheckoutComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
