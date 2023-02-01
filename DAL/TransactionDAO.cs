namespace DAL {

    public class TransactionDAO
    {
        public Guid Id { get; set; }=Guid.NewGuid();

        public string Libelle { get; set; }

        public decimal Montant { get; set; }

        public DateTime DateCreation { get; set; }=DateTime.Now;

        public DateTime DateTransaction {get;set;}

        
        public Guid IdCategorie{get;set;}

        public Guid IdClient{get;set;}

        public ClientDAO Client{get;set;}

        public CategorieDAO Categorie{get;set;}

    }
}