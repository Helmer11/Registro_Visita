import { Component, OnInit, ViewChild } from '@angular/core';
import { VisitantesTran } from 'src/app/Models/Visitante';
import { VisitanteService } from './Visitante.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AddVisitanteComponent } from './Agregar/AddVisitante/AddVisitante.component';

@Component({
  selector: 'app-Visitante',
  templateUrl: './Lista_Visitante.component.html',
  styleUrls: ['./Lista_Visitante.component.scss']
})
export class Lista_VisitanteComponent implements OnInit {

  Visitante: VisitantesTran[] = [];
  loading: boolean = false;
  cantidadRegistro!: number;
  indice = 1;
  ListaForm!: FormGroup;
  visitaID!: number;

  @ViewChild (AddVisitanteComponent) visit: (AddVisitanteComponent) | undefined
  constructor(public _visitaService: VisitanteService, private _formB: FormBuilder) { }

  ngOnInit() {
    this.getForm();
    this.getVisitante();
  }

  public getForm(){
      this.ListaForm = this._formB.group({
        NombreVisitante: ['', Validators.required]
      })
  }

public getVisitante() {
    let nombreVisita = this.ListaForm.value.NombreVisitante;
    this.loading = true;
    setTimeout(() => {
      this._visitaService.getVisitante(nombreVisita).subscribe((res: VisitantesTran) => {
        this.Visitante = res  as VisitantesTran[];
        if (this.Visitante.length > 0){
            this.cantidadRegistro = this.Visitante.length;
        } else {
          this.cantidadRegistro = 0;
        }
      })
      this.loading = false;
    }, 2000);
}

public BuscarVisitante(){
    this.getVisitante()
}

public ActualizarCampo(){
  this.ListaForm.patchValue({
    NombreVisitante: ""
  });
  this.getVisitante()
}

public VisitanteEdita( idVisitante: any ){
    this.visitaID = Number(idVisitante);
    this.visit?.getDetalleVisitante(this.visitaID);
}


}
