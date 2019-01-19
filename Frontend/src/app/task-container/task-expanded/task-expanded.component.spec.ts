import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TaskExpandedComponent } from './task-expanded.component';

describe('TaskExpandedComponent', () => {
  let component: TaskExpandedComponent;
  let fixture: ComponentFixture<TaskExpandedComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TaskExpandedComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TaskExpandedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
