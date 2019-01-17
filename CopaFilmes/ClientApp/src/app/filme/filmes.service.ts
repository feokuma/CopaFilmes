import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Filme } from './filme';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FilmesService {

  private readonly API = 'https://localhost:5001/api/filmes';

  private filmes;
  private champions;

  constructor(private http: HttpClient) { }

  list() {
    this.filmes = this.http.get<Filme[]>(this.API);
    return this.filmes;
  }

  executeChampionship(movieNames): Observable<Filme[]> {
    var header = new HttpHeaders();
    header.append("Access-Control-Allow-Origin", "*");
    this.champions = this.http.post<Filme[]>(this.API, movieNames, {headers: header});
    return this.champions;
  }

}
