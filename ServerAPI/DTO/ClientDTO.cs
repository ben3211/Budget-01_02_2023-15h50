public class ClientDTO {
    public Guid Id {get; set;}
    public string N { get; set; }

    public IEnumerable<TransactionDTO> Ts {get;set;}
}