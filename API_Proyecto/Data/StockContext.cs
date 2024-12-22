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
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Producto>().HasData(
                    new Producto
                    {
                        IdProducto = 1,
                        Descripcion = "Producto A",
                        Tamanio = new Tamanio { alto = 30, ancho = 20, profundidad = 15 }
                    },
                    new Producto
                    {
                        IdProducto = 2,
                        Descripcion = "Producto B",
                        Tamanio = new Tamanio { alto = 50, ancho = 40, profundidad = 25 }
                    }
                );

            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.CUIT);
            modelBuilder.Entity<Producto>()
                .HasKey(c => c.IdProducto);
            modelBuilder.Entity<Posicion>()
                .HasKey(c => c.Id);
            
        }
    }
}
