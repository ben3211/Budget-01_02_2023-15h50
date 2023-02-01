using DAL;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

[Route("{controller}")]

public class ClientController : ControllerBase
{
    private readonly BudgetDal db;
    private readonly IMapper mapper;


    public ClientController(BudgetDal db, IMapper mapper)
    {
        this.db = db;
        this.mapper = mapper;

    }

    // GET /Client
    [HttpGet("")]
    public IEnumerable<ClientDTO> GetClients()
    {
        var daos = db.Clients;
        var dtos = mapper.Map<IEnumerable<ClientDTO>>(daos);

        return dtos;
    }

    [HttpGet("{id}")]
    public ClientDTO GetClient(Guid id)
    {

        var dao = db.Clients.Include(c => c.Transactions).FirstOrDefault(c => c.Id == id);
        var dto = mapper.Map<ClientDTO>(dao);
        return dto;
    }

}

