using AutoMapper;
using DAL;
using Microsoft.AspNetCore.Mvc;

[Route("{controller}")]

public class CategorieController : ControllerBase
{
    private readonly BudgetDal db;
    private readonly IMapper mapper;

    public CategorieController(BudgetDal db, IMapper mapper)
    {
        this.db = db;
        this.mapper = mapper;
    }

    // GET /Categorie
    [HttpGet("")]
    public IEnumerable<CategorieDTO> GetCategories()
    {
        var daos = db.Categories;
        var dtos = mapper.Map<IEnumerable<CategorieDTO>>(daos);

        return dtos;
    }
}