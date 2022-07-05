import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { EventosService } from '../../Eventos.service';
import { EventosTran } from '../../../../Models/Eventos';

@Component({
  selector: 'app-InsertarEventos',
  templateUrl: './InsertarEventos.component.html',
  styleUrls: ['./InsertarEventos.component.css']
})
export class InsertarEventosComponent implements OnInit {

formEvento!: FormGroup;

  constructor(private _formB: FormBuilder, private _eventService: EventosService) { }

  ngOnInit() {
    this.Formu();
  }


  public Formu(){
    this.formEvento = this._formB.group({
      nombre: ['', Validators.required],
      Descripcion: ['',Validators.required],
      fecha: ['',Validators.required],
      hora:['',Validators.required]
    })
  }

  public setAddEvento(){


      let evento = {
        eventoNombre: this.formEvento.value.nombre,
        eventoDescripcion: this.formEvento.value.Descripcion,
        eventoFecha: this.formEvento.value.fecha,
        eventoHora: this.formEvento.value.hora
      }
   this._eventService.setEvento(evento).subscribe(res => {

   })
  }



}
