using DAL;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;


[Route("{controller}")]

public class TransactionController : ControllerBase
{
    private readonly BudgetDal db;
    private readonly IMapper mapper;


    public TransactionController(BudgetDal db, IMapper mapper)
    {
        this.db = db;
        this.mapper = mapper;

    }

    // GET /Transaction
    [HttpGet("")]
    public IEnumerable<TransactionDTO> GetTransactions()
    {
        var daos = db.Transactions;
        var dtos = mapper.Map<IEnumerable<TransactionDTO>>(daos);

        return dtos;
    }
}