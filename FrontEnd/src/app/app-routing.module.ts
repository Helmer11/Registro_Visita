import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Lista_VisitanteComponent } from './Page/Visitante/Lista_Visitante.component';
import { LayoutComponent } from './shared/layout/layout/layout.component';
import { Lista_EventosComponent } from './Page/Eventos/Lista_Eventos.component';
import { HistoricoComponent } from './Page/Historico/Historico.component';
import { AddVisitanteComponent } from './Page/Visitante/Agregar/AddVisitante/AddVisitante.component';

 export const routes: Routes = [
  {
    path : "",
    component: LayoutComponent,
    children: [
      {
        path: "visitante",
        component: Lista_VisitanteComponent
      },
      {
        path: "Eventos",
        component: AddVisitanteComponent
      },
      {
        path: "Agregar",
        component: AddVisitanteComponent
      },
      {
        path: "**",
        redirectTo: "",
        pathMatch: "full"
      }
    ]
  }



]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
