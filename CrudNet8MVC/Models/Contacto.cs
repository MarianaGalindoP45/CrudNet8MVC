using System.ComponentModel.DataAnnotations;

namespace CrudNet8MVC.Models
{
    public class Contacto
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "El nombre es necesario")]
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }

        [Required(ErrorMessage = "El número de teléfono es necesario")]
        public string? Telefono { get; set; }

        [Required (ErrorMessage = "El correo es necesario")]
        public string? Correo { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}
