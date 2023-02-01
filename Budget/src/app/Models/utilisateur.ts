export class Utilisateur {
    constructor(Nom: string, public Transactions: {id:string, l:string, m:number, d:Date}[]) {
        this.Nom = Nom;

    }

    //#region Nom
    private _Nom!: string;
    public get Nom() {
        return this._Nom;
    }
    public set Nom(v: string) {
        // TODO : Vérifier la valeur de v
        // if(condition){
        // throw new Error('message');
        // }
        this._Nom = v;
    }
    //#endregion

    //#region Prenom
    private _Prenom!: string;
    public get Prenom() {
        return this._Prenom;
    }
    public set Prenom(v: string) {
        // TODO : Vérifier la valeur de v
        // if(condition){
        // throw new Error('message');
        // }
        this._Prenom = v;
    }
    //#endregion

    //#region mail
    private _mail!: string;
    public get mail() {
        return this._mail;
    }
    public set mail(v: string) {
        // TODO : Vérifier la valeur de v
        // if(condition){
        // throw new Error('message');
        // }
        this._mail = v;
    }

    
    
    
    //#endregion
}