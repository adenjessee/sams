import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.scss']
})
export class ContactComponent implements OnInit {

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
