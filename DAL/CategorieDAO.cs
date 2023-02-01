namespace DAL {

    public class CategorieDAO
    {
        public Guid Id { get; set; }=Guid.NewGuid();

        public string Libelle { get; set; }

        public Boolean Depense { get; set; }

        public ICollection<TransactionDAO> Transactions {get;set;}

    }
}