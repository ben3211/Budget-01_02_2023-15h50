import { FormGroupDirective } from "@angular/forms";
import { Guid } from "guid-typescript";

export interface SearchResult {
    libelle:string;
    description:string;
    id:Guid;
}