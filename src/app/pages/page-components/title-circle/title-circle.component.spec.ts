import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TitleCircleComponent } from './title-circle.component';

describe('WelcomeCircleComponent', () => {
  let component: TitleCircleComponent;
  let fixture: ComponentFixture<TitleCircleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TitleCircleComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TitleCircleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
