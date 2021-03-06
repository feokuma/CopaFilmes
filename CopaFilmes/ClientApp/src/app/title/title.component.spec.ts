import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TitleComponent } from './title.component';

describe('TitleComponent', () => {
  let component: TitleComponent;
  let fixture: ComponentFixture<TitleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TitleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TitleComponent);
    component = fixture.componentInstance;
    component.text = "Title Test";
    component.description = "Description Test";
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should change text', () => {
    expect(component.text).toEqual("Title Test");
    expect(component.description).toEqual("Description Test");
  });
});
