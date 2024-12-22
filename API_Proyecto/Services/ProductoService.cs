using API_Proyecto.Data;
using API_Proyecto.Models;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace API_Proyecto.Services
{
    
    public class ProductoService
    {
        private readonly StockContext _context;

        private static readonly List<Producto> Productos = new List<Producto>
        {
           
        };

        public ProductoService (StockContext stockContext)
        {
            _context = stockContext;
        }

        public IEnumerable<Producto> GetAll()
        {
            /*if (_context != null)
            {
                return _context.Productos.ToList();
            }
            
            return new List<Producto>();*/

            _context.Productos.Add(new Producto { IdProducto = 1, Descripcion = "Producto A", Tamanio = new Tamanio { alto = 30, ancho = 20, profundidad = 15 }, Posiciones = [new Posicion { Pasillo = 'A', Seccion = 1, Estanteria = 3, Nivel = 1, Cantidad = 15 }] });
            _context.Productos.Add(new Producto { IdProducto = 2, Descripcion = "Producto B", Tamanio = new Tamanio { alto = 50, ancho = 40, profundidad = 25 }, Posiciones = [new Posicion { Pasillo = 'B', Seccion = 6, Estanteria = 3, Nivel = 1, Cantidad = 5 }] });
            _context.Productos.Add(new Producto { IdProducto = 3, Descripcion = "Producto C", Tamanio = new Tamanio { alto = 10, ancho = 10, profundidad = 5 }, Posiciones = [new Posicion { Pasillo = 'F', Seccion = 9, Estanteria = 15, Nivel = 6, Cantidad = 50 }] });

            

        }

        public Producto? GetById(int id) { 

           return _context.Productos.FirstOrDefault(p => p.IdProducto == id);

        }

        public void UpdateDescription(int id, string description)
        {
            var productoActualizar = _context.Productos.FirstOrDefault(o => o.IdProducto == id);

            if (productoActualizar != null) { 
                productoActualizar.Descripcion = description;
                
            }
        }


    }
}
