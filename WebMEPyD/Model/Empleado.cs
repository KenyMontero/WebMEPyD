using System.ComponentModel.DataAnnotations;

namespace WebMEPyD.Model
{
    public class Empleado
    {
        [Key]
        public int IdEmpleados { get; set; }
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public string? CodigoEmpleado { get; set; }
        public string? CorreoEmpleados { get; set; }
        public string? TelefonoOficina  { get; set; }
        public string? Celular { get; set; }
        public string? Cargo { get; set; }
        public string? Departamento { get; set; }
        public int IdCompañia { get; set; }

    }
}
