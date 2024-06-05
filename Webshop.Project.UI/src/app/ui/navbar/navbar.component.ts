import { Component } from '@angular/core';
import { SmartphoneService } from '../../services/smartphone.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css'
})
export class NavbarComponent {

  smartphones : any[] = []
/**
 *
 */
constructor(private smartphoneService : SmartphoneService) { }

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

  getSmartphonesBySearch(userSearch : number|string){
    this.smartphoneService.getSmartphoneBySearch(userSearch).subscribe(
      (data) => {
        this.smartphones = data; // Handle the response data as needed
        console.log(this.smartphones);
      },
      (error) => {
        console.error('Error fetching smartphones:', error);
      }
  )}

  userSearch: number|string = "";

  onSelectedSearch(value: string): void {
    if(value === "0"){
      this.userSearch = "";
    }
    else{
      this.userSearch = Number(value);
    }

	}
}
