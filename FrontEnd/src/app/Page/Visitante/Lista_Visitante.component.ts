import { Component, OnInit } from '@angular/core';
import { VisitantesTran } from 'src/app/Models/Visitante';
import { VisitanteService } from './Visitante.service';

@Component({
  selector: 'app-Visitante',
  templateUrl: './Lista_Visitante.component.html',
  styleUrls: ['./Lista_Visitante.component.css']
})
export class Lista_VisitanteComponent implements OnInit {

  Visitante: VisitantesTran[] = [];

  constructor(private _visitaService: VisitanteService) { }

  ngOnInit() {
    this.getVisitante();
  }



public getVisitante(){
  this._visitaService.getVisitante().subscribe((res: VisitantesTran[]) => {
    this.Visitante = res as unknown as VisitantesTran[]
  })
}




}
