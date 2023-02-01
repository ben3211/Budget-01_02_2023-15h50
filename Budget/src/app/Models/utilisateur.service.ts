import { Injectable } from '@angular/core';
import { SCRUDService } from './scrud.service';
import { Utilisateur } from './utilisateur';

@Injectable({
  providedIn: 'root'
})
export abstract class UtilisateurService extends SCRUDService<Utilisateur> {
}

