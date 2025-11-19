namespace GestionmedicaAPI.Dtos.Request
{
    public class TurnoPUTrequest
    {
        public DateTime Fechaturno { get; set; }
        public string Especialidad { get; set; }
        public string Estadoturno { get; set; }
        public int Idpaciente { get; set; }

    }
}
