import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Child1component } from './child1component';

describe('Child1component', () => {
  let component: Child1component;
  let fixture: ComponentFixture<Child1component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Child1component]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Child1component);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
