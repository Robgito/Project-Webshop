import { Component } from '@angular/core';
import { SmartphoneService } from '../services/smartphone.service';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.css'
})
export class HomePageComponent {

  smartphones : any[] = []

  /**
   *
   */
  constructor(private smartphoneService : SmartphoneService) {}
  ngOnInit(): void {
    this.smartphoneService.getSmartphones().subscribe(
      (data) => {
        this.smartphones = data.slice(0, 4); // Limit to first 4 smartphones
        console.log(this.smartphones);
      },
      (error) => {
        console.error('Error fetching smartphones:', error);
      }
    );
}
}