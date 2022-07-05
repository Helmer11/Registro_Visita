import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Lista_VisitanteComponent } from './Page/Visitante/Lista_Visitante.component';
import { LayoutComponent } from './shared/layout/layout/layout.component';
import { Lista_EventosComponent } from './Page/Eventos/Lista_Eventos.component';
import { HistoricoComponent } from './Page/Historico/Historico.component';

 export const routes: Routes = [{
    path : "",
    component: LayoutComponent,
    children: [
      {
        path: "Visitante",
        component: Lista_VisitanteComponent,
      },
      {
        path:"Eventos",
        component: Lista_EventosComponent
      },
      {
        path:"Historico",
        component: HistoricoComponent
      }


  ]
 }]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
