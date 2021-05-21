import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TitleTextPointsComponent } from './title-text-points.component';

describe('TitleTextPointsComponent', () => {
  let component: TitleTextPointsComponent;
  let fixture: ComponentFixture<TitleTextPointsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TitleTextPointsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TitleTextPointsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
