import { Component, OnInit } from '@angular/core';
import { TitleCircleComponent } from '../title-circle/title-circle.component';

@Component({
  selector: 'app-title',
  templateUrl: './title.component.html',
  styleUrls: ['./title.component.scss']
})
export class TitleComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}
