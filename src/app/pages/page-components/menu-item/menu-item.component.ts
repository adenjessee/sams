import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-menu-item',
  templateUrl: './menu-item.component.html',
  styleUrls: ['./menu-item.component.scss']
})
export class MenuItemComponent implements OnInit {

  @Input() src!: string;
  @Input() name!: string;
  @Input() price!: number;
  @Input() description!: string;

  constructor() { }

  ngOnInit(): void {
  }

}
