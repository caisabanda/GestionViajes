using System.ComponentModel.DataAnnotations;

namespace GestionViajesCaisabanda.Models
{
    public class Destino
    {
        [Key]
        public int destino_id { get; set; } 
        public string nombre { get; set; }
        public string pais { get; set; }
        public string descripcion { get; set; }
        public decimal costo { get; set; }
    }
}