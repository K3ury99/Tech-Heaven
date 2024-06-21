using Microsoft.EntityFrameworkCore;
using Tienda.Infrastructure.Models;

namespace Tienda.Infrastructure.Context
{
    public class TechHeavenContext : DbContext
    {
        public TechHeavenContext(DbContextOptions<TechHeavenContext> options) : base(options)
        {
        }

        public DbSet<Producto> Producto { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Orden> Orden { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public object Productos { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
