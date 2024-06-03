import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { SmartphoneService } from '../services/smartphone.service';
import { Smartphone } from '../model/smartphone.model';
import { SmartphoneResolveService } from '../services/smartphone-resolve.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-update-smartphone',
  templateUrl: './update-smartphone.component.html',
  styleUrl: './update-smartphone.component.css'
})
export class UpdateSmartphoneComponent implements OnInit {
  [x: string]: any;

  phone: any;
  constructor(private smartphoneservice: SmartphoneService, private activatedRoute: ActivatedRoute) { }
  ngOnInit(): void {
    this.phone = this.activatedRoute.snapshot.data['phone'];
  }


  updateSmartphone(smartphoneForm: NgForm) {
    this.smartphoneservice.updatesmartphone(this.phone.id, this.phone).subscribe(
      (response) => {
        console.log(response);
        alert("Smartphone successfully updated!!");
        smartphoneForm.reset();
      },
      (error) => {
        alert("An error has occurred when updating the product");
        console.log(error);
      }
    );
  }
}
