import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { VisitanteService } from '../../Visitante.service';
import { Lista_VisitanteComponent } from '../../Lista_Visitante.component';

@Component({
  selector: 'app-AddVisitante',
  templateUrl: './AddVisitante.component.html',
  styleUrls: ['./AddVisitante.component.css']
})
export class AddVisitanteComponent implements OnInit {


formEvento!: FormGroup;

constructor(private _formB: FormBuilder, private _Visita: VisitanteService,
            private _toast: ToastrService) { }

ngOnInit(): void {
  this.Formu();
}
@ViewChild(Lista_VisitanteComponent) listaVisitante: Lista_VisitanteComponent | undefined;
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
this._Visita.setVisitante(evento).subscribe(res => {
  if(res.valueOf() == "1"){
this._toast.success("El visitante se ha agregado", "Exito");
  }
},err=> {
  this._toast.error("Error al momento de agregar al visitante", "Error");
})
window.location.reload();
}

}
