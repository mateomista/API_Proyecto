using System.ComponentModel.DataAnnotations;

namespace API_Proyecto.Models
{
    public class Tamanio
    {
        [Required]
        [MaxLength(10000)]
        public int alto { get; set; }
        
        [Required]
        [MaxLength(10000)]
        public int ancho { get; set; }

        [Required]
        [MaxLength(10000)]
        public int profundidad { get; set; }
    }
}
