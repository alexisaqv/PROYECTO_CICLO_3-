using System.ComponentModel.DataAnnotations;

namespace TallerMecanicoJAYAP.Models
{
    public class SoatModelo
    {
        [Required(ErrorMessage = "EL campo es obligatorio")]//obligatoria
        public int IdSeguro { get; set; }
        [Required(ErrorMessage = "EL campo es obligatorio")]//obligatoria
        public string? TipoSeguro { get; set; }
        [Required(ErrorMessage = "EL campo es obligatorio")]//obligatoria
        public string? FechaCompra { get; set; }
        [Required(ErrorMessage = "EL campo es obligatorio")]//obligatoria
        public string? FechaVencimiento { get; set; }
        



    }
}




