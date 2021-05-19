import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-title-circle',
  templateUrl: './title-circle.component.html',
  styleUrls: ['./title-circle.component.scss']
})
export class TitleCircleComponent implements OnInit {

  @Input() title!: string;
  @Input() paragraph!: string;

  constructor() { }

  ngOnInit(): void {
  }

}
