import { TestBed, async, ComponentFixture } from '@angular/core/testing';

import { AppComponent } from './app.component';
import { TitleComponent } from './title/title.component';
import { PodiumComponent } from './podium/podium.component';
import { FilmeComponent } from './filme/filme.component';
import { FilmesService } from './filme/filmes.service';

describe('AppComponent', () => {
  let component: AppComponent;
  let fixture: ComponentFixture<AppComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ 
        AppComponent, 
        TitleComponent, 
        PodiumComponent, 
        FilmeComponent, 
        FilmesService
      ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AppComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

});
