namespace GestionmedicaAPI.Dtos.Response
{
    public class _PacienteGet
    { 
        public int Id { get; set; }
        public int Idpaciente { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public long Numerotelefono { get; set; }
    }
}
