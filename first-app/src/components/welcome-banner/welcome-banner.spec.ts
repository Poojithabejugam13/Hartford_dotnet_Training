import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WelcomeBanner } from './welcome-banner';

describe('WelcomeBanner', () => {
  let component: WelcomeBanner;
  let fixture: ComponentFixture<WelcomeBanner>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [WelcomeBanner]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WelcomeBanner);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
