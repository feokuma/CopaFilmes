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
  selectedFilmes = [];
  champions = [];
  countSelectedMovies: number = 0;

  constructor(private filmesService: FilmesService){ }

  ngOnInit(){
    this.filmesService.list().subscribe(data => this.filmes = data);
  }

  selectionChange(event){
     if(event.checked){
      // insert filme to array
      this.selectedFilmes.push(event.filme);
    }
    else {
      // find index of unselected filme
      let index = this.selectedFilmes.indexOf(event.filme);
      // remove filme from array
      this.selectedFilmes.splice(index, 1);
    }

    // update count selected items
    this.countSelectedMovies = this.selectedFilmes.length;
  }

  executeChampionship(){
    this.filmesService.executeChampionship(this.selectedFilmes).subscribe(data => this.champions = data);
    console.log(JSON.stringify(this.champions));
  }
}
