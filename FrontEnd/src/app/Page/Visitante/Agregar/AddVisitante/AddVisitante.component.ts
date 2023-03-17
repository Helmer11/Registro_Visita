import { VisitantesTran } from 'src/app/Models/Visitante';
import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { VisitanteService } from '../../Visitante.service';
import { Lista_VisitanteComponent } from '../../Lista_Visitante.component';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-AddVisitante',
  templateUrl: './AddVisitante.component.html',
  styleUrls: ['./AddVisitante.component.css']
})
export class AddVisitanteComponent implements OnInit {

formVisita!: FormGroup;
visitanteID: number = 0;
detalleVisitante: VisitantesTran[] = [];

constructor(private _formB: FormBuilder, private _VisitaService: VisitanteService,
            private _toast: ToastrService, private _router: ActivatedRoute) {

             }
ngOnInit(): void {
  this.Formu();
}

public Formu(){
  this.formVisita = this._formB.group({
    visitanteNombre: ['', Validators.required],
    visitanteApellido: ['',Validators.required],
    visitantefecha: ['',Validators.required],
    //hora:['',Validators.required]
  })
}


public setAddVisitante(){
  let evento = {
    visitaNombre: this.formVisita.value.visitanteNombre,
    visitaApellido: this.formVisita.value.visitanteApellido,
    registroFecha: this.formVisita.value.Visitantefecha,
    //registroHora: this.formEvento.value.Hora

  }
this._VisitaService.setVisitante(evento).subscribe(res => {
  if(res.valueOf() == "1"){
this._toast.success("El visitante se ha agregado", "Exito");
  }
},err=> {
  this._toast.error("Error al momento de agregar al visitante", "Error");
})
window.location.reload();
}


public getDetalleVisitante(visitaID: number) {
  this.visitanteID = visitaID;
  this._VisitaService.getVisitanteDetalle(visitaID).subscribe( res => {
       this.detalleVisitante = res as VisitantesTran[]

       this.formVisita.patchValue({
        visitanteNombre:    this.detalleVisitante[0].visitaNombre,
        visitanteApellido:  this.detalleVisitante[0].visitaApellido,
        visitantefecha:     this.detalleVisitante[0].registroFecha
      })
  })
}

public setUpdateVisitante(){
  let evento = {
    visitanteId: this.visitanteID,
    visitaNombre: this.formVisita.value.visitanteNombre,
    visitaApellido: this.formVisita.value.visitanteApellido,
    registroFecha: this.formVisita.value.visitantefecha,
    registroEstado: 'A',
    registroUsuario: 'hsalas'
    //registroHora: this.formEvento.value.Hora

  }
this._VisitaService.setEditaVisita(evento).subscribe(res => {
  if(res.valueOf() == "1"){
this._toast.success("Se Actualizo el registro", "Exito");
  }
},err=> {
  this._toast.error("Error al momento de actualizar al visitante", "Error");
})
window.location.reload();
}

public getDeleteVisitante(id: number){
  this._VisitaService.setEliminarVisitante(id).subscribe(res => {
    if(res.valueOf() == "1"){
      this._toast.success("Se Elimino El registro ", "Exito");
        }
      },err=> {
        this._toast.error("Error al momento de agregar al visitante", "Error");
      })
      window.location.reload();

      }
}


