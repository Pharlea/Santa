using Microsoft.EntityFrameworkCore;

public class AppDbContext: DbContext
{
    //construtor
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options) {}

    //propriedades
    public DbSet<Produto> tbProdutos => Set<Produto>();
}