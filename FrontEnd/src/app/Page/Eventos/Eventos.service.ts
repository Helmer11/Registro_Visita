import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { APIURL } from '../../shared/APIURL';
import { EventosTran } from '../../Models/Eventos';

@Injectable({
  providedIn: 'root'
})
export class EventosService {

constructor(private _htpp: HttpClient) { }


public getlistaEvento(){
  return this._htpp.get<EventosTran[]>(APIURL.Eventos.lista);
}


public setEvento(event: EventosTran){

  let param = "eventoNombre:" +event.eventoNombre +
              "&eventoDescripcion:" +event.eventoDescripcion+
              "&eventoFecha:"  +event.eventoFecha+
                "&eventoHora:" + event.eventoHora
                debugger;
  const headerOptions = new HttpHeaders({'Content-Type':'application/json'});

  return this._htpp.post(APIURL.Eventos.agregar, param, {headers: headerOptions});
}



}
