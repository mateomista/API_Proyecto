using System.ComponentModel.DataAnnotations;

namespace API_Proyecto.Models
{
    public class Posicion
    {
        public int Id { get; set; }
        public required char Pasillo { get; set; }
        public required ushort Seccion { get; set; }
        public required ushort Estanteria { get; set; }
        public required ushort Nivel { get; set; }
        public ushort? Cantidad { get; set; }

    }
}
