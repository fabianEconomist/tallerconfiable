using System.ComponentModel.DataAnnotations;

namespace tallerconfiable.Models
{
    public class PersonaModelo
    {
        public int Idpersona { get; set; }
        [Required(ErrorMessage="El campo es obligatorio")]
        public string? Identificacion { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string? Apellido { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string? Nacimiento { get; set; }
        
    }
}
