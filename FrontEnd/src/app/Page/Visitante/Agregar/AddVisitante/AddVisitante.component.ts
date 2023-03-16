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

formEvento!: FormGroup;
visitanteID!: number;
detalleVisitante!: VisitantesTran;

constructor(private _formB: FormBuilder, private _VisitaService: VisitanteService,
            private _toast: ToastrService, private _router: ActivatedRoute) {

             }
ngOnInit(): void {
  this.Formu();
}

public Formu(){
  this.formEvento = this._formB.group({
    visitanteNombre: ['', Validators.required],
    visitanteApellido: ['',Validators.required],
    Visitantefecha: ['',Validators.required],
    //hora:['',Validators.required]
  })
}


public setAddVisitante(){
  let evento = {
    visitaNombre: this.formEvento.value.visitanteNombre,
    visitaApellido: this.formEvento.value.visitanteApellido,
    Visitantefecha: this.formEvento.value.Visitantefecha,
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

  this._VisitaService.getVisitanteDetalle(visitaID).subscribe((res: VisitantesTran) => {
         console.log(res.visitaNombre);

          res.visitaApellido,
        res.registroFecha
  })
}

}
