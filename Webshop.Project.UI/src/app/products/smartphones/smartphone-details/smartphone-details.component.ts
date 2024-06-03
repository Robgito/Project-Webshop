import { Component } from '@angular/core';
import { SmartphoneService } from '../../../services/smartphone.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-smartphone-details',
  templateUrl: './smartphone-details.component.html',
  styleUrl: './smartphone-details.component.css'
})
export class SmartphoneDetailsComponent {

  smartphone: any;

  constructor(private smartservice: SmartphoneService, private route: ActivatedRoute) {
    this.route.params.subscribe(params => {
      const phoneId = params['smartphoneId']
      this.smartservice.getDetailedSmartphoneById(phoneId).subscribe(data => {
        this.smartphone = data;
        console.log(data)
      })
    })
  }

  AddToCart(productId: any) {
   console.log(productId);
  }
}
