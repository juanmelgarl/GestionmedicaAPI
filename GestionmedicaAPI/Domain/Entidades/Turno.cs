using System.ComponentModel.DataAnnotations;

namespace GestionmedicaAPI.Domain.Entidades
{
    public class Turno
    {
        [Required]
        public int Id { get; set; }
        public DateTime Fechaturno  { get; set; }
        public string Especialidad { get; set; }
        public int Idpaciente { get; set; }
        public string Estadoturno { get; set; }
        public Paciente paciente { get; set; }
    }
}
