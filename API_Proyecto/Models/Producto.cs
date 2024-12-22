using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Proyecto.Models
{
    public class Producto
    {
        
        public required uint IdProducto { get; set; }
        public required string Descripcion { get; set; }
        [NotMapped]
        public required Tamanio Tamanio { get; set; }
        public uint Cantidad { get; set; }
        public required List<Posicion> Posiciones { get; set; }

    }
}
