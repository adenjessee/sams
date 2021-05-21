import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HalfImageHalfTextComponent } from './half-image-half-text.component';

describe('HalfImageHalfTextComponent', () => {
  let component: HalfImageHalfTextComponent;
  let fixture: ComponentFixture<HalfImageHalfTextComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HalfImageHalfTextComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HalfImageHalfTextComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
