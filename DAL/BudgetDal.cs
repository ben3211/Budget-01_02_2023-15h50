using Microsoft.EntityFrameworkCore;

namespace DAL{



public partial class BudgetDal : DbContext {public BudgetDal(){this.Database.EnsureDeleted(); this.Database.EnsureCreated();}

protected override void OnConfiguring(DbContextOptionsBuilder builder){
    base.OnConfiguring(builder);

    builder.UseSqlServer("data source=.; initial catalog=Budget; integrated security=true;");
    
    }

    public virtual DbSet<ClientDAO> Clients {get;set;}
    public virtual DbSet<TransactionDAO> Transactions {get;set;}
    public virtual DbSet<CategorieDAO> Categories {get;set;}


}
}