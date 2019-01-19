import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FilmeComponent } from './filme.component';

describe('FilmeComponent', () => {
  let component: FilmeComponent;
  let fixture: ComponentFixture<FilmeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FilmeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FilmeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should set movie name', () => {
    component.name = 'Movie Name';
    expect(component.name).toBe('Movie Name');
  });

  it('should set movie year', () => {
    component.year = 2018;
    expect(component.year).toBe(2018);
  });
});
