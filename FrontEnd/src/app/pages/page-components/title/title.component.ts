import { Component, Input, OnInit } from '@angular/core';
import { TitleCircleComponent } from '../title-circle/title-circle.component';

@Component({
  selector: 'app-title',
  templateUrl: './title.component.html',
  styleUrls: ['./title.component.scss']
})
export class TitleComponent implements OnInit {

  @Input() title!: string;
  @Input() paragraph!: string;

  constructor() { }

  ngOnInit(): void {
  }

}
