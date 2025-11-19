using System.ComponentModel.DataAnnotations;

namespace GestionmedicaAPI.Domain.Entidades
{
    public class Paciente
    {
        [Required]
            public int Id { get; set; }
        public int Idpaciente { get; set; } 
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public long Numerotelefono { get; set; }
      
    }
}
