import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListaCardapiosComponent } from './components/lista-cardapios/lista-cardapios.component';
import { HeaderComponent } from './components/header/header.component';
import { CardapioComponent } from './components/cardapio/cardapio.component';

@NgModule({
  declarations: [
    AppComponent,
    ListaCardapiosComponent,
    HeaderComponent,
    CardapioComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
