import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { APIURL } from '../../shared/APIURL';
import { VisitantesTran } from '../../Models/Visitante';


@Injectable({
  providedIn: 'root'
})
export class VisitanteService {


  filtroVisitante: any = {
    PageIndex: 1,
    PageSize: 10,
    Linea:0

  }

constructor(private _http: HttpClient ) { }

public getVisitante(){
  return this._http.get(APIURL.Visitante.lista);
}

public setVisitante(visi: VisitantesTran){
  const headerOptions = new HttpHeaders({'Content-Type':'application/json'});
  return this._http.post(APIURL.Visitante.Agregar, visi, {headers: headerOptions })
}



}
