import { Component, OnInit } from '@angular/core';
import { Brand } from '../model/smartphone.model';
import { BrandService } from '../services/brand.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-show-brands',
  templateUrl: './show-brands.component.html',
  styleUrl: './show-brands.component.css'
})
export class ShowBrandsComponent implements OnInit {
  brands: any;
  constructor(private brandService: BrandService, private router: Router) { }

  ngOnInit(): void {
    this.brandService.getBrands().subscribe(
      (data) => {
        this.brands = data;
        console.log(this.brands);
      },
      (error) => {
        console.error('Error fetching brands:', error);
      }
    );
  }

  deleteBrandById(brandId: number) {
    this.brandService.deleteBrandById(brandId).subscribe(
      (response) => {
        alert("Brand successfully deleted!!");
        this.ngOnInit();
      },
      (error) => {
        alert("An error has occurred when deleting the brand");
        console.log(error);
      }
    );
  }

  updateBrandById(brandId: number) {
    this.router.navigate(['/update-brand', { brandId: brandId }]);
  }
}
