import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Description } from './description';

describe('Description', () => {
  let component: Description;
  let fixture: ComponentFixture<Description>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Description]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Description);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
