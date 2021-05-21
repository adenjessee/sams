import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HalfImageHalfTextPointsComponent } from './half-image-half-text-points.component';

describe('HalfImageHalfTextPointsComponent', () => {
  let component: HalfImageHalfTextPointsComponent;
  let fixture: ComponentFixture<HalfImageHalfTextPointsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HalfImageHalfTextPointsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HalfImageHalfTextPointsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
