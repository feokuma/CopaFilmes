import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { TitleComponent } from './title/title.component';
import { FilmeComponent } from './filme/filme.component';
import { HttpClientModule } from '@angular/common/http';
import { PodiumComponent } from './podium/podium.component';

@NgModule({
  declarations: [
    AppComponent,
    TitleComponent,
    FilmeComponent,
    PodiumComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
