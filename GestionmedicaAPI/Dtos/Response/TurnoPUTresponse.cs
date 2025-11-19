namespace GestionmedicaAPI.Dtos.Response
{
    public class TurnoPUTrequest
    {
        public int Id { get; set; }
        public DateTime Fechaturno { get; set; }
        public string Especialidad { get; set; }
        public int Idpaciente { get; set; }
        public string Estadoturno { get; set; }
    }
}
