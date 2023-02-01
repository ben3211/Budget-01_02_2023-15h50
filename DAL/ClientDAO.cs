namespace DAL {

    public class ClientDAO
    {
        public Guid Id { get; set; }=Guid.NewGuid();

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string mail { get; set; }

        public ICollection<TransactionDAO> Transactions {get;set;}
    }
}