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

  locationNames: string[] = [];

  constructor(private locationService: LocationService) { }

  ngOnInit(): void {
    this.getLocations();
    this.locationNames = this.locations.map(a => a.name);
    console.log("hey there");
    console.log(this.locations);
  }

  getLocations(): void {
    this.locationService.getLocations();
  }

}
