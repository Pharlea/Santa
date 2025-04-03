using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Data 
{
        public class AppDbContext : DbContext
    {
        //sobrescrevendo o método do pai para abrir o tipo do banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("DataSource=app.db"); //o "app" pode ser substituído por outro nome para o banco de dados.

        //declarando tabelas
        public DbSet<Livro>? tbLivros { get; set; }
    }
}