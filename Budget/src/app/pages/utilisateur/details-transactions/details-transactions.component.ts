import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Guid } from 'guid-typescript';
import { Utilisateur } from 'src/app/Models/utilisateur';
import { UtilisateurService } from 'src/app/Models/utilisateur.service';

@Component({
  selector: 'app-details-transactions',
  templateUrl: './details-transactions.component.html',
  styleUrls: ['./details-transactions.component.scss']
})
export class DetailsTransactionsComponent implements OnInit {
  constructor(private utilisateurService:UtilisateurService, private activatedRoute:ActivatedRoute){
    
  }

 async ngOnInit() {

    let id=this.activatedRoute.snapshot.params["id"];
    let guid=Guid.parse(id);

    this.utilisateur=await this.utilisateurService.getItemAsync(guid);

    }
    utilisateur?:Utilisateur;
}
