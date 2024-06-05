import { Component, OnInit } from '@angular/core';
import { CategoryService } from '../services/category.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-show-categories',
  templateUrl: './show-categories.component.html',
  styleUrl: './show-categories.component.css'
})
export class ShowCategoriesComponent implements OnInit {
  categories: any;

  constructor(private categoryservice: CategoryService, private router: Router) { }

  ngOnInit(): void {
    this.categoryservice.getCategories().subscribe(
      (data) => {
        this.categories = data;
      },
      (error) => {
        console.error('Error fetching brands:', error);
      }
    );
  }

  deleteCategoryById(categoryId: number) {
    this.categoryservice.deleteCategoriesById(categoryId).subscribe(
      (data) => {
        alert("Category successfully deleted!!");
        this.ngOnInit();
      },
      (error) => {
        alert("An error has occurred when deleting the category");
        console.log(error);
      }
    );
  }

  updateCategoryById(categoryId: any) {
    this.router.navigate(['/update-category', { categoryId: categoryId }]);
  }
}
