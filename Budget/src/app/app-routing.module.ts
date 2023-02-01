import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AccueilComponent } from './pages/accueil/accueil.component';
import { DetailsTransactionsComponent } from './pages/utilisateur/details-transactions/details-transactions.component';
import { ListeUtilisateurComponent } from './pages/utilisateur/liste-utilisateur/liste-utilisateur.component';


const routes: Routes = [
  {path:"accueil", component:AccueilComponent},
  {path:"liste-utilisateur", component:ListeUtilisateurComponent},
  {path:"details-transactions/:id", component:DetailsTransactionsComponent},
  {path:"**", redirectTo:"accueil"}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
