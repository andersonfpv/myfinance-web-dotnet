using Microsoft.EntityFrameworkCore;
using myfinance_web_dotnet_domain.Entities;

namespace myfinance_web_dotnet_infra;


public DbSet <PlanoConta> PlanoConta {get; set;}
public DbSet <Transacao> Transacao {get; set;}



public class MyFinanceDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=myfinance;Trusted_Connection=True");
    }
    
}
