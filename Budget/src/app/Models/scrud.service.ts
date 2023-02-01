import { Injectable } from '@angular/core';
import { Guid } from "guid-typescript";
import { SearchResult } from './search-result';

@Injectable({
  providedIn: 'root'
})

export abstract class SCRUDService<T> {
    abstract saveItemAsync(item:T):Promise<Guid>;
    abstract deleteItemAsync(item:Guid):Promise<void>;
    abstract updateItemAsync(item:Guid):Promise<void>;
    abstract getItemAsync(item:Guid):Promise<T>;
    abstract searchItemAsync(searchText:string):Promise<SearchResult[]>;
}




