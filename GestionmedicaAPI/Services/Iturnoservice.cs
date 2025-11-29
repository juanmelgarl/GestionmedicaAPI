using GestionmedicaAPI.Dtos.Request;

namespace GestionmedicaAPI.Services
{
    public interface Iturnoservice
    {
        Task<List<TurnoGet>> Listar();
        Task<TurnoGet> Get(int id);
        Task crear(Pacientecreaterequest dto);
        Task<bool> Eliminarturno(int id);
        Task<bool> Actualizarturno(TurnoPUTrequest dto, int id);
    }
}
