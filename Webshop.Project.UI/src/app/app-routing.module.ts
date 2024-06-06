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
import { HomePageComponent } from './home-page/home-page.component';
import { SmartphoneResolveService } from './services/smartphone-resolve.service';
import { UpdateSmartphoneComponent } from './update-smartphone/update-smartphone.component';
import { AddBrandComponent } from './add-brand/add-brand.component';
import { ShowBrandsComponent } from './show-brands/show-brands.component';
import { UpdateBrandComponent } from './update-brand/update-brand.component';
import { BrandResolveService } from './services/brand-resolve.service';
import { AddCategoryComponent } from './add-category/add-category.component';
import { ShowCategoriesComponent } from './show-categories/show-categories.component';
import { UpdateCategoryComponent } from './update-category/update-category.component';
import { CategoryResolveService } from './services/category-resolve.service';

const routes: Routes = [
  { path: '', component: HomePageComponent },
  { path: 'smartphones', component: SmartphonesComponent },
  { path: 'admin', component: AdminComponent },
  { path: 'smartphones/:smartphoneId', component: SmartphoneDetailsComponent },
  { path: 'basket', component: BasketComponent },
  { path: 'signin', component: SignInComponent },
  { path: 'signup', component: SignUpComponent },
  { path: 'checkout', component: CheckoutComponent },
  { path: 'add-smartphone', component: AddSmartphoneComponent },
  { path: 'show-products', component: ShowProductsComponent },
  { path: 'update-smartphone', component: UpdateSmartphoneComponent, resolve: { phone: SmartphoneResolveService } },
  { path: 'add-brand', component: AddBrandComponent },
  { path: 'show-brands', component: ShowBrandsComponent },
  { path: 'update-brand', component: UpdateBrandComponent, resolve: { brand: BrandResolveService } },
  { path: 'add-category', component: AddCategoryComponent },
  { path: 'show-categories', component: ShowCategoriesComponent },
  { path: 'update-category', component: UpdateCategoryComponent, resolve: { category: CategoryResolveService } }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
