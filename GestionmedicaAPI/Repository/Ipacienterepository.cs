using GestionmedicaAPI.Domain.Entidades;

namespace GestionmedicaAPI.Repository
{
    public interface Ipacienterepository
    {
        Task<List<Paciente>> GetPacientes();
        Task<Paciente> Getforid(int id);
        Task Save();
        Task Add(Paciente paciente);
        Task delete(Paciente paciente);
        Task Update(Paciente paciente);
        Task Updatepatch(Paciente paciente) ;
    }
}
