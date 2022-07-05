import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { VisitanteService } from '../../Visitante.service';

@Component({
  selector: 'app-AddVisitante',
  templateUrl: './AddVisitante.component.html',
  styleUrls: ['./AddVisitante.component.css']
})
export class AddVisitanteComponent implements OnInit {


formEvento!: FormGroup;

constructor(private _formB: FormBuilder, private _Visita: VisitanteService) { }

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


public setAddVisitante(){
  let evento = {
    visitaNombre: this.formEvento.value.nombre,
    visitaApellido: this.formEvento.value.apellido,
    Visitantefecha: this.formEvento.value.fecha

  }
this._Visita.setVisitante(evento).subscribe(res => {

})
}

}
