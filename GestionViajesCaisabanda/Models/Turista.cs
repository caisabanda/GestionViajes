using System.ComponentModel.DataAnnotations;

namespace GestionViajesCaisabanda.Models
{
    public class Turista
    {
        [Key]
        public int turista_id { get; set; } 
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
    }
}