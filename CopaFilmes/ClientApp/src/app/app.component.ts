import { Component, OnInit } from '@angular/core';
import { FilmesService } from './filme/filmes.service';
import { Filme } from './filme/filme';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  filmes: Array<Filme>;
  countSelectedMovies: number = 0;

  constructor(private filmesService: FilmesService){ }

  ngOnInit(){
    this.filmesService.list().subscribe(data => this.filmes = data);
  }

  selectionChange(event){
    event.checked ? this.countSelectedMovies++ : this.countSelectedMovies--;
    console.log(`${event.name} - ${event.checked}`);
  }

  executeChampionship(){
    console.log(event);
  }
}
