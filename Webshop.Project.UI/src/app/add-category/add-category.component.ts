import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Category } from '../model/smartphone.model';
import { CategoryService } from '../services/category.service';

@Component({
  selector: 'app-add-category',
  templateUrl: './add-category.component.html',
  styleUrl: './add-category.component.css'
})
export class AddCategoryComponent implements OnInit {
category: Category = {
  name: "",
};

constructor(private categoryservice: CategoryService) {}

ngOnInit(): void { };

addCategory(categoryForm: NgForm) {
  if (categoryForm.invalid) {
    return;
  }

  this.categoryservice.addCategory(this.category).subscribe(
    (data: Category) => {
      categoryForm.reset();
      alert("Category successfully added!!");
      },
      (error) => {
        alert("An error has occurred when adding the category");
        console.log(error);
      }
  );
  }
}
