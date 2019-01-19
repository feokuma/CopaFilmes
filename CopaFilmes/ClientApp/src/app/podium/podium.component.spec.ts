import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PodiumComponent } from './podium.component';

describe('PodiumComponent', () => {
  let component: PodiumComponent;
  let fixture: ComponentFixture<PodiumComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PodiumComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PodiumComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should set position', () => {
    component.position = "1";
    expect(component.position).toBe('1');
    expect(document.getElementById('position').innerText).toBe('1º');
  });

  it('should set movie name', () => {
    component.filmeName = "Test Movie";
    expect(component.filmeName).toBe("Test Movie");
  });
});
