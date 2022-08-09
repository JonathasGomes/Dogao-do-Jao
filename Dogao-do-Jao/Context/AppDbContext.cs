using Dogao_do_Jao.Models;
using Microsoft.EntityFrameworkCore;

namespace Dogao_do_Jao.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Lanche> Lanches { get; set; }
    }
}
