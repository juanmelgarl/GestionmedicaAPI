using GestionmedicaAPI.Domain.Entidades;

namespace GestionmedicaAPI.Dtos.Response
{
    public class TurnoGet
    {
        public int Id { get; set; }
        public DateTime Fechaturno { get; set; }
        public string Especialidad { get; set; }
        public int Idpaciente { get; set; }
        public string Estadoturno { get; set; }
        public Paciente paciente { get; set; }
    }
}
