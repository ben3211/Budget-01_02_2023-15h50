import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Guid } from 'guid-typescript';
import { lastValueFrom } from 'rxjs';
import { SearchResult } from './search-result';
import { Transactions } from './transaction';
import { Utilisateur } from './utilisateur';
import { UtilisateurService } from './utilisateur.service';

@Injectable({
  providedIn: 'root'
})

export class UtilisateurHttpService implements UtilisateurService {
  constructor (private httpClient: HttpClient) {

  }

  saveItemAsync(item: Utilisateur): Promise<Guid> {
    throw new Error('Method not implemented.');
  }
  deleteItemAsync(item: Guid): Promise<void> {
    throw new Error('Method not implemented.');
  }
  updateItemAsync(item: Guid): Promise<void> {
    throw new Error('Method not implemented.');
  }
  async getItemAsync(id: Guid): Promise<Utilisateur> {

    var requete=this.httpClient.get(`http://localhost:5067/Client/${id.toString()}`);
    var promesse=lastValueFrom(requete);

    var dto=await promesse as {id: string , n: string , ts:{id:string, l:string, m:number, d:Date }[]};

    //comment transformer en string?
    var resultat=new Utilisateur(dto.n, dto.ts);
    // resultat.tsString = dto.ts.map(x => `l: ${x.l}, m: ${x.m}, d: ${x.d}`).join('\n');
    // resultat.tsString = JSON.stringify(dto.ts);
    return resultat;
  }

  async searchItemAsync(searchText: string) {
    var requete = this.httpClient.get("http://localhost:5067/Client");

    var promesse = lastValueFrom(requete);
    var dtos=await promesse as {id:string,n:string}[];
    
    var resultats = dtos.map(dto=>({
      id:Guid.parse(dto.id),
      libelle:dto.n
    } as SearchResult));
    return resultats;
  }
}
