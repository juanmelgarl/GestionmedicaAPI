namespace GestionmedicaAPI.Dtos.Response
{
    public class Pacientecreateresponse
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido  { get; set; }
        public string Numerotelefono { get; set; }
        public DateTime Fecha { get; set; }
    }
}
