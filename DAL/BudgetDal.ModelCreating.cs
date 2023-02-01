

using Microsoft.EntityFrameworkCore;

namespace DAL {
    public partial class BudgetDal{

    protected override void OnModelCreating(ModelBuilder builder){
    base.OnModelCreating(builder);

    // Faire le lien entre les différentes DAO avec Id comme FK
    builder.Entity<TransactionDAO>().HasOne(c=>c.Categorie).WithMany(c=>c.Transactions).HasForeignKey(c=>c.IdCategorie);
    builder.Entity<TransactionDAO>().HasOne(c=>c.Client).WithMany(c=>c.Transactions).HasForeignKey(c=>c.IdClient);

    // Modification (aucune)

    // SEED

    // Initalisation de la BDD avec des Categories

    var c1 = new CategorieDAO(){ Libelle= "Salaire", Depense=false};
    var c2 = new CategorieDAO(){ Libelle= "Alimentaire", Depense=true};
    var c3 = new CategorieDAO(){ Libelle= "Loisir", Depense=true};

    builder.Entity<CategorieDAO>().HasData(new List<CategorieDAO>() {c1, c2, c3});

    // Initalisation de la BDD avec des Transactions

    var client1 = new ClientDAO(){ Nom= "Madoff", Prenom="Bernard", mail="bernard.madoff@escroc.com"};
    var client2 = new ClientDAO(){ Nom= "Tapis", Prenom="Bernard", mail="bernard.Tapis@ministre.com"};
    var client3 = new ClientDAO(){ Nom= "Less", Prenom="Desir", mail="desir.Less@voyages.com"};

    builder.Entity<ClientDAO>().HasData(new List<ClientDAO>() {client1, client2, client3});

    // Initalisation de la BDD avec des Transactions

    var t1 = new TransactionDAO(){ Libelle= "Virement EDF Benoit", Montant=2200,IdCategorie=c1.Id, IdClient=client1.Id, DateTransaction=new DateTime(2022, 11, 4)};
    var t2 = new TransactionDAO(){ Libelle= "Course à FranPrix", Montant=500, IdCategorie=c2.Id, IdClient=client1.Id, DateTransaction=new DateTime(2022, 11, 4)};
    var t3 = new TransactionDAO(){ Libelle= "Voyages Voyages", Montant=200, IdCategorie=c3.Id, IdClient=client2.Id, DateTransaction=new DateTime(2022, 11, 4)};

    builder.Entity<TransactionDAO>().HasData(new List<TransactionDAO>() {t1, t2, t3});

    

    }
}
}