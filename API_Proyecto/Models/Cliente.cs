using System.ComponentModel.DataAnnotations;

namespace API_Proyecto.Models
{
    public class Cliente
    {
        public int CUIT { get; set; }

        public string Apynom { get; set; }

        public string RazonSocial { get; set; }

        public List<Posicion> Posiciones { get; set; }
    }
}
