import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { SmartphonesComponent } from './products/smartphones/smartphones/smartphones.component';
import { NavbarComponent } from './ui/navbar/navbar.component';
import { BasketComponent } from './basket/basket.component';
import { SmartphoneDetailsComponent } from './products/smartphones/smartphone-details/smartphone-details.component';
import { PaginationComponent } from './pagination/pagination.component';
import { SignInComponent } from './sign/sign-in/sign-in.component';
import { SignUpComponent } from './sign/sign-up/sign-up.component';
import { FooterComponent } from './ui/footer/footer.component';
import { CheckoutComponent } from './checkout/checkout.component';
import { HomePageComponent } from './home-page/home-page.component';

@NgModule({
  declarations: [
    AppComponent,
    SmartphonesComponent,
    NavbarComponent,
    BasketComponent,
    SmartphoneDetailsComponent,
    PaginationComponent,
    SignInComponent,
    SignUpComponent,
    FooterComponent,
    CheckoutComponent,
    HomePageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    RouterModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
