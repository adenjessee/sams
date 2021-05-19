import { identifierModuleUrl } from '@angular/compiler';
import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-title-text',
  templateUrl: './Title-text.component.html',
  styleUrls: ['./title-text.component.scss']
})
export class TitleTextComponent implements OnInit {

  @Input() title!: string;
  @Input() paragraph!: string;

  constructor(){}
  ngOnInit(): void {
  }

}
