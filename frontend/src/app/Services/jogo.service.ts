import { Jogo } from './../Models/Jogo';
import { environment } from './../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class JogoService {

  baseUrl = `${environment.mainUrlAPI}tabelajogo`;

  constructor(private http: HttpClient) { }

  getAll(): Observable<Jogo[]> {
    return this.http.get<Jogo[]>(this.baseUrl);
  }

  put(jogo: Jogo) {
    return this.http.put(`${this.baseUrl}/${jogo.id}`, jogo);
  }

  post(jogo: Jogo) {
    return this.http.post(this.baseUrl, jogo);
  }

  delete(id: number) {
    return this.http.delete(`${this.baseUrl}/${id}`);
  }

}
