import { Component, OnInit } from '@angular/core';
import { FoodLocation } from '../../../food-location';
import { LocationService } from '../../../services/location.service';

@Component({
  selector: 'app-select-location',
  templateUrl: './select-location.component.html',
  styleUrls: ['./select-location.component.scss']
})
export class SelectLocationComponent implements OnInit {

  selectedLocation?: FoodLocation;

  locations: FoodLocation[] = [];

  constructor(private locationService: LocationService) { }

  ngOnInit(): void {
    this.locationService.getLocations().subscribe((data: FoodLocation[]) => {
      this.locations = data; 
    });
  }

  getLocations(): void {
    this.locationService.getLocations();
  }

}
