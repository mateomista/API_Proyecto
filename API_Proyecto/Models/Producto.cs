using Microsoft.AspNetCore.Mvc;

namespace API_Proyecto.Models
{
    public class Producto
    {
        public required uint IdProducto { get; set; }
        public required string Descripcion { get; set; }
        public required Tamanio Tamanio { get; set; }
        public uint Cantidad { get; set; }
        public required List<Posicion> Posiciones { get; set; }

    }
}
