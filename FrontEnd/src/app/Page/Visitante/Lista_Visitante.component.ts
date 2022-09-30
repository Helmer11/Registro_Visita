import { Component, OnInit } from '@angular/core';
import { VisitantesTran } from 'src/app/Models/Visitante';
import { VisitanteService } from './Visitante.service';

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

  constructor(public _visitaService: VisitanteService) { }

  ngOnInit() {
    this.getVisitante();
  }

public getVisitante() {
    this.loading = true;
    setTimeout(() => {
      this._visitaService.getVisitante().subscribe((res: VisitantesTran) => {
        this.Visitante = res  as VisitantesTran[];

        if (this.Visitante.length > 0){
            this.cantidadRegistro = this.Visitante.length;
        } else {
          this.cantidadRegistro = 0;
        }

      })
      this.loading = false;
    }, 4000);
}

public BuscarVisitante(){

}



}
