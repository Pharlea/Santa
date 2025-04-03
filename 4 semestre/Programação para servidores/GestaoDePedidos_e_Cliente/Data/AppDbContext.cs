using GestaoDePedidos_e_Cliente.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoDePedidos_e_Cliente.Data
{
    public class AppDbContext: DbContext
    {
        public DbSet<Cliente> tbClientes { get; set; }
        public DbSet<Pedido> tbPedidos { get; set; }
        public DbSet<Produto> tbProdutos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opt) 
            => opt.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}