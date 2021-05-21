import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-half-image-half-text-contact',
  templateUrl: './half-image-half-text-contact.component.html',
  styleUrls: ['./half-image-half-text-contact.component.scss']
})
export class HalfImageHalfTextContactComponent implements OnInit {
  
  @Input() title!: string;
  @Input() phone!: string;
  @Input() hqLocation!: string;
  @Input() email!: string;
  @Input() src!: string;
  @Input() logoSrc!: string;
  @Input() imageLeft: boolean = true;

  constructor() { }

  ngOnInit(): void {
  }

}
