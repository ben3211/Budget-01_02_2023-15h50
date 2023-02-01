import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AccueilComponent } from './pages/accueil/accueil.component';

import { UtilisateurService } from './Models/utilisateur.service';
import { UtilisateurHttpService } from './Models/utilisateur-http.service';
import { PagesComponent } from './pages/pages.component';
// import { ControlsComponent } from './controls/controls.component';
import { ListSearchResultComponent } from './controls/list-search-result/list-search-result.component';
import { ListeUtilisateurComponent } from './pages/utilisateur/liste-utilisateur/liste-utilisateur.component';
import { DetailsTransactionsComponent } from './pages/utilisateur/details-transactions/details-transactions.component';


@NgModule({
  declarations: [
    AppComponent,
    AccueilComponent,
    ListeUtilisateurComponent,
    PagesComponent,
    // ControlsComponent,
    ListSearchResultComponent,
    DetailsTransactionsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [
    {provide: UtilisateurService, useClass:UtilisateurHttpService}
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
