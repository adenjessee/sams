import { Component, Input, OnInit, HostBinding } from '@angular/core';
import {DomSanitizer, SafeStyle} from '@angular/platform-browser';

@Component({
  selector: 'app-title-circle',
  templateUrl: './title-circle.component.html',
  styleUrls: ['./title-circle.component.scss']
})
export class TitleCircleComponent implements OnInit {

  @Input() title!: string;
  @Input() paragraph!: string;
  @Input() height : string = "100%";

  ngOnInit(): void {
  }

}
