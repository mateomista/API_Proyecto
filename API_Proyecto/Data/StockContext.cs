using API_Proyecto.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Proyecto.Data
{
    public class StockContext : DbContext
    {
        public StockContext(DbContextOptions<StockContext> options)
            : base(options)
        {
        }

        public DbSet<API_Proyecto.Models.Producto>? Productos { get; set; }
        public DbSet<API_Proyecto.Models.Posicion>? Posiciones { get; set; }
        public DbSet<API_Proyecto.Models.Cliente>? Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.CUIT);
            modelBuilder.Entity<Producto>()
                .HasKey(c => c.IdProducto);
            modelBuilder.Entity<Posicion>()
                .HasKey(c => c.Id);
            
        }
    }
}
