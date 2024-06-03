import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { SmartphonesComponent } from './products/smartphones/smartphones/smartphones.component';
import { NavbarComponent } from './ui/navbar/navbar.component';
import { BasketComponent } from './basket/basket.component';
import { SmartphoneDetailsComponent } from './products/smartphones/smartphone-details/smartphone-details.component';
import { AdminComponent } from './admin/admin/admin.component';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { FormsModule } from '@angular/forms';
import { AddSmartphoneComponent } from './add-smartphone/add-smartphone.component';
import { ShowProductsComponent } from './show-products/show-products.component';


@NgModule({
  declarations: [
    AppComponent,
    SmartphonesComponent,
    NavbarComponent,
    BasketComponent,
    SmartphoneDetailsComponent,
    AdminComponent,
    AddSmartphoneComponent,
    ShowProductsComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    RouterModule,
    FormsModule
   
  ],
  providers: [
    provideAnimationsAsync()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
