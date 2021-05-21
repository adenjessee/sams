import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-title-text-points',
  templateUrl: './title-text-points.component.html',
  styleUrls: ['./title-text-points.component.scss']
})
export class TitleTextPointsComponent implements OnInit {

  @Input() title!: string;
  @Input() points!: string;

  constructor() { }

  ngOnInit(): void {
  }

}
