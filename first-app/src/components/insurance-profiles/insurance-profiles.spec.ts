import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InsuranceProfiles } from './insurance-profiles';

describe('InsuranceProfiles', () => {
  let component: InsuranceProfiles;
  let fixture: ComponentFixture<InsuranceProfiles>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [InsuranceProfiles]
    })
    .compileComponents();

    fixture = TestBed.createComponent(InsuranceProfiles);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
