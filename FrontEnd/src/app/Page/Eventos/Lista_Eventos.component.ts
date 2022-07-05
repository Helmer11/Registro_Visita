import { Component, OnInit } from '@angular/core';
import { EventosTran } from '../../Models/Eventos';
import { EventosService } from './Eventos.service';

@Component({
  selector: 'app-ListaEventos',
  templateUrl: './Lista_Eventos.component.html',
  styleUrls: ['./Lista_Eventos.component.css']
})
export class Lista_EventosComponent implements OnInit {


  listaEvento: EventosTran[] = [];

  constructor(private _eventService: EventosService) { }

  ngOnInit() {
    this.getlistaEvento();
  }


public getlistaEvento(){
      this._eventService.getlistaEvento().subscribe((event: EventosTran[])=> {
          this.listaEvento = event as EventosTran[]
      })
}



}
