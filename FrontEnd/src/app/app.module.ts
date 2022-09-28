import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { Lista_VisitanteComponent } from './Page/Visitante/Lista_Visitante.component';
import { AddVisitanteComponent } from './Page/Visitante/Agregar/AddVisitante/AddVisitante.component';
import { Lista_EventosComponent } from './Page/Eventos/Lista_Eventos.component';
import { InsertarEventosComponent } from './Page/Eventos/Insertar/InsertarEventos/InsertarEventos.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { LayoutComponent } from './shared/layout/layout/layout.component';
import { ToastrModule } from 'ngx-toastr';

@NgModule({
  declarations: [
    AppComponent,
    LayoutComponent,
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
    BrowserAnimationsModule,
    ToastrModule.forRoot()

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
