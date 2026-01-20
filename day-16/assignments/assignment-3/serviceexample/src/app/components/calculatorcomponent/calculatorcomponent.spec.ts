import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Calculatorcomponent } from './calculatorcomponent';

describe('Calculatorcomponent', () => {
  let component: Calculatorcomponent;
  let fixture: ComponentFixture<Calculatorcomponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Calculatorcomponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Calculatorcomponent);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
