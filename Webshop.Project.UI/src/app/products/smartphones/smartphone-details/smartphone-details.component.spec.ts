import { ComponentFixture, TestBed } from '@angular/core/testing';
import { RouterLink } from '@angular/router';
import { SmartphoneDetailsComponent } from './smartphone-details.component';

describe('SmartphoneDetailsComponent', () => {
  let component: SmartphoneDetailsComponent;
  let fixture: ComponentFixture<SmartphoneDetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [SmartphoneDetailsComponent]
    })
      .compileComponents();

    fixture = TestBed.createComponent(SmartphoneDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
