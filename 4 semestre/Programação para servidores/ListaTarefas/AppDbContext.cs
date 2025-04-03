using Microsoft.EntityFrameworkCore;

public class AppDbContext: DbContext
{
    //construtor
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options) {}

    //propriedades
    public DbSet<Tarefa> tbTarefas => Set<Tarefa>();
}