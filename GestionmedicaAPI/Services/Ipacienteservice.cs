using GestionmedicaAPI.Dtos.Request;

namespace GestionmedicaAPI.Services
{
    public interface Ipacienteservice
    {
        Task<List<_PacienteGet>> Listar();
        Task<_PacienteGet> Get(int id);
        Task crear(Pacientecreaterequest dto);
        Task<bool> Eliminarpaciente(int id);
        Task<bool> Actualizarpaciente(PacientePUTrequest dto,int id);
    }
}
