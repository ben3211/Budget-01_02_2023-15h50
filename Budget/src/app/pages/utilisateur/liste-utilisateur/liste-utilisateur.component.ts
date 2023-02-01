import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { SearchResult } from 'src/app/Models/search-result';
import { UtilisateurService } from 'src/app/Models/utilisateur.service';

@Component({
  selector: 'app-liste-utilisateur',
  templateUrl: './liste-utilisateur.component.html',
  styleUrls: ['./liste-utilisateur.component.scss']
})


export class ListeUtilisateurComponent implements OnInit {
  constructor(private utilisateurService: UtilisateurService,
    private router: Router) {}
    

    resultatsResearch?:SearchResult[];

    async ngOnInit(){

      this.resultatsResearch= await this.utilisateurService.searchItemAsync("") ;   
    
    
    }

    showDetail(r:SearchResult) {
      this.router.navigateByUrl("/details-transactions/"+r.id);
    }  
}
