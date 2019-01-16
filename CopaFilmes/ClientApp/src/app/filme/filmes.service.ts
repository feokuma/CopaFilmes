import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Filme } from './filme';

@Injectable({
  providedIn: 'root'
})
export class FilmesService {

  private readonly API = 'https://localhost:5001/api/filmes';
  
  private filmes;

  constructor(private http: HttpClient) { }

  list(){
    this.filmes = this.http.get<Filme[]>(this.API);
    return this.filmes;
  }

  executeChampionship(movieNames:string[]){
    var selectedMovies = new Array();

    movieNames.forEach(element => {
      selectedMovies.push(this.filmes.find(x => x.titulo === element))
    });

    console.log(selectedMovies);
  }
}
