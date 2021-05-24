import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-half-image-half-text-points',
  templateUrl: './half-image-half-text-points.component.html',
  styleUrls: ['./half-image-half-text-points.component.scss']
})
export class HalfImageHalfTextPointsComponent implements OnInit {

  @Input() title!: string;
  @Input() points!: string[];
  @Input() src!: string;
  @Input() imageLeft: boolean = true;

  constructor() { }

  ngOnInit(): void {
  }

}
