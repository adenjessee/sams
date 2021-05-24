import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-half-image-half-text',
  templateUrl: './half-image-half-text.component.html',
  styleUrls: ['./half-image-half-text.component.scss']
})
export class HalfImageHalfTextComponent implements OnInit {

  @Input() title!: string;
  @Input() body!: string;
  @Input() src!: string;
  @Input() imageLeft: boolean = true;

  constructor() { }

  ngOnInit(): void {
  }

}
