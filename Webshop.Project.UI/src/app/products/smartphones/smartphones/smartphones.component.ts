import { Component, OnInit } from '@angular/core';
import { SmartphoneService } from '../../../services/smartphone.service';

@Component({
  selector: 'app-smartphones',
  templateUrl: './smartphones.component.html',
  styleUrl: './smartphones.component.css'
})
export class SmartphonesComponent implements OnInit {
  smartphones : any[] = []

  /**
   *
   */
  constructor(private smartphoneService : SmartphoneService) {}
  ngOnInit(): void {
    this.smartphoneService.getSmartphones().subscribe(
      (data) => {
        this.smartphones = data; // Handle the response data as needed
        console.log(this.smartphones);
      },
      (error) => {
        console.error('Error fetching smartphones:', error);
      }
    );
  }
}
