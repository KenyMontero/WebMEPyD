using System.ComponentModel.DataAnnotations;

namespace WebMEPyD.Model
{
    public class Compañia
    {
        [Key]
        public int IdCompañia { get; set; }
        public string? NombreCompañia { get; set; }
        public string? Web { get; set; }
        public string? telefono { get; set; }
        public string? CodigoPostal { get; set; }
        public string? Direcion { get; set; }
        public string? Ciudad { get; set; }
        public string? Pais { get; set; }
        public string? Correo { get; set; }
    }
}
