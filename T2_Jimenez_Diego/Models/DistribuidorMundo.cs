using System.ComponentModel.DataAnnotations;

namespace T2_Jimenez_Diego.Models
{
    public class DistribuidorMundo
    {
        [Key]
        public int ID { get; set; }
        public string NombreDistribuidor { get; set; }
        public string RazonSocial { get; set; }
        public string Telefono { get; set; }
        public int AnioInicioOperacion { get; set; }
        public string Contacto { get; set; }
    }
}
