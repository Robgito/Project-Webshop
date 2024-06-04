import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { CategoryService } from '../services/category.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-update-category',
  templateUrl: './update-category.component.html',
  styleUrl: './update-category.component.css'
})
export class UpdateCategoryComponent implements OnInit {
  category: any;
  constructor(private categoryservice: CategoryService, private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    this.category = this.activatedRoute.snapshot.data['category'];
  }

  updateCategory(categoryForm: NgForm) {
    this.categoryservice.updateCategory(this.category.id, this.category).subscribe(
      (response) => {
        console.log(response);
        alert("Category successfully updated!!");
        categoryForm.reset();
      },
      (error) => {
        alert("An error has occurred when updating the category");
        console.log(error);
      }
    );
  }
}
