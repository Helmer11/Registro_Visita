import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { Lista_VisitanteComponent } from './Page/Visitante/Lista_Visitante.component';
import { AddVisitanteComponent } from './Page/Visitante/Agregar/AddVisitante/AddVisitante.component';
import { Lista_EventosComponent } from './Page/Eventos/Lista_Eventos.component';
import { InsertarEventosComponent } from './Page/Eventos/Insertar/InsertarEventos/InsertarEventos.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';

@NgModule({
  declarations: [
    AppComponent,
    Lista_VisitanteComponent,
    AddVisitanteComponent,
    Lista_EventosComponent,
    InsertarEventosComponent,
  ],
  imports: [
    BrowserModule,
    CommonModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
