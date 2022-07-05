import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { APIURL } from '../../shared/APIURL';
import { VisitantesTran } from '../../Models/Visitante';


@Injectable({
  providedIn: 'root'
})
export class VisitanteService {

constructor(private _http: HttpClient ) { }


public getVisitante(){
  return this._http.get<VisitantesTran[]>(APIURL.Visitante.lista);
}

public setVisitante(visi: VisitantesTran){
  const headerOptions = new HttpHeaders({'Content-Type':'application/json'});
  return this._http.post(APIURL.Visitante.Agregar, visi, {headers: headerOptions })
}





}
