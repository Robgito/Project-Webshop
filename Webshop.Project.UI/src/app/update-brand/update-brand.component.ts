import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { BrandService } from '../services/brand.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-update-brand',
  templateUrl: './update-brand.component.html',
  styleUrl: './update-brand.component.css'
})
export class UpdateBrandComponent implements OnInit {
  brand: any;

  constructor(private brandService: BrandService, private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    this.brand = this.activatedRoute.snapshot.data['brand'];
  }

  updateBrand(brandForm: NgForm) {
    if (brandForm.invalid) {
      return;
    }
    this.brandService.updateBrand(this.brand.id, this.brand).subscribe(
      (response) => {
        console.log(response);
        alert("Brand successfully updated!!");
        brandForm.reset();
      },
      (error) => {
        alert("An error has occurred when updating the brand");
        console.log(error);
      }
    );
  }
}
