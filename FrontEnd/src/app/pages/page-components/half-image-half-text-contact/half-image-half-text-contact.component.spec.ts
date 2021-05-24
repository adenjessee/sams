import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HalfImageHalfTextContactComponent } from './half-image-half-text-contact.component';

describe('HalfImageHalfTextContactComponent', () => {
  let component: HalfImageHalfTextContactComponent;
  let fixture: ComponentFixture<HalfImageHalfTextContactComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HalfImageHalfTextContactComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HalfImageHalfTextContactComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
