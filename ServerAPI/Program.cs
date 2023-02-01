using AutoMapper;
using DAL;


var configurationMapping = new MapperConfiguration(options =>
{
    options.CreateMap<ClientDAO, ClientDTO>()
        .ForMember(c => c.Id, option => option.MapFrom(c => c.Id))
        .ForMember(c => c.N, option => option.MapFrom(c => c.Nom))
        .ForMember(c => c.Ts, option => option.MapFrom(c => c.Transactions))
        .ReverseMap();

    options.CreateMap<TransactionDAO, TransactionDTO>()
        .ForMember(c => c.Id, option => option.MapFrom(c => c.Id))
        .ForMember(c => c.L, option => option.MapFrom(c => c.Libelle))
        .ForMember(c => c.M, option => option.MapFrom(c => c.Montant))
        .ForMember(c => c.D, option => option.MapFrom(c => c.DateCreation))
        .ForMember(c => c.Cat, option => option.MapFrom(c => c.Categorie.Libelle))
        .ReverseMap();

    options.CreateMap<CategorieDAO, CategorieDTO>()
        .ForMember(c => c.Id, option => option.MapFrom(c => c.Id))
        .ForMember(c => c.L, option => option.MapFrom(c => c.Libelle))
        .ForMember(c => c.D, option => option.MapFrom(c => c.Depense))
        .ReverseMap();
});
var mapper = configurationMapping.CreateMapper();




var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<BudgetDal>();

builder.Services.AddSingleton<IMapper>(mapper);

var app = builder.Build();

app.UseCors(options =>
{
    options.AllowAnyHeader();
    options.AllowAnyMethod();
    options.AllowAnyOrigin();
});



app.MapGet("/", () => "Le serveur fonctionne");

app.MapControllers();

app.Run();
