import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Parentcomponent } from './parentcomponent';

describe('Parentcomponent', () => {
  let component: Parentcomponent;
  let fixture: ComponentFixture<Parentcomponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Parentcomponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Parentcomponent);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
