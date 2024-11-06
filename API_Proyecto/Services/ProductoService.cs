using API_Proyecto.Models;

namespace API_Proyecto.Services
{
    public class ProductoService
    {

        //private readonly ProductoContext _context;

        /*public ProductoService(ProductoContext context) { 
            _context = context;
        
        }*/

        private static readonly List<Producto> Productos = new List<Producto>
        {
            new Producto { IdProducto = 1, Descripcion = "Producto A", Tamanio = new Tamanio { alto = 30, ancho = 20, profundidad = 15 }, Posiciones = [new Posicion { Pasillo = 'A', Seccion = 1, Estanteria = 3, Nivel = 1, Cantidad = 15 }] },
            new Producto { IdProducto = 2, Descripcion = "Producto B", Tamanio = new Tamanio { alto = 50, ancho = 40, profundidad = 25 }, Posiciones = [new Posicion { Pasillo = 'B', Seccion = 6, Estanteria = 3, Nivel = 1, Cantidad = 5 }] },
            new Producto { IdProducto = 3, Descripcion = "Producto C", Tamanio = new Tamanio { alto = 10, ancho = 10, profundidad = 5 }, Posiciones = [new Posicion { Pasillo = 'F', Seccion = 9, Estanteria = 15, Nivel = 6, Cantidad = 50 }] }
        };


        public IEnumerable<Producto> GetAll()
        {
            return Productos;
        }

        public Producto? GetById(int id) { 

           return Productos.FirstOrDefault(p => p.IdProducto == id);

        }

        public void UpdateDescription(int id, string description)
        {
            var productoActualizar = Productos.FirstOrDefault(o => o.IdProducto == id);

            if (productoActualizar != null) { 
                productoActualizar.Descripcion = description;
                
            }
        }


    }
}
