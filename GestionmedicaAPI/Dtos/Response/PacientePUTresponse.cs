namespace GestionmedicaAPI.Dtos.Response
{
    public class PacientePUTresponse
    {
        public int ID { get; set; }
        public int Idpaciente { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int Numerotelefono { get; set; }
    }
}
