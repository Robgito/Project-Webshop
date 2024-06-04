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
import { PaginationComponent } from './pagination/pagination.component';
import { SignInComponent } from './sign/sign-in/sign-in.component';
import { SignUpComponent } from './sign/sign-up/sign-up.component';
import { FooterComponent } from './ui/footer/footer.component';
import { CheckoutComponent } from './checkout/checkout.component';
import { UpdateSmartphoneComponent } from './update-smartphone/update-smartphone.component';
import { AddBrandComponent } from './add-brand/add-brand.component';
import { ShowBrandsComponent } from './show-brands/show-brands.component';
import { UpdateBrandComponent } from './update-brand/update-brand.component';
import { AddCategoryComponent } from './add-category/add-category.component';
import { ShowCategoriesComponent } from './show-categories/show-categories.component';
import { UpdateCategoryComponent } from './update-category/update-category.component';


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
    AdminComponent,
    AddSmartphoneComponent,
    ShowProductsComponent,
    UpdateSmartphoneComponent,
    AddBrandComponent,
    ShowBrandsComponent,
    UpdateBrandComponent,
    AddCategoryComponent,
    ShowCategoriesComponent,
    UpdateCategoryComponent,
  

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
