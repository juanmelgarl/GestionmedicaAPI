using GestionmedicaAPI.Domain.Entidades;

namespace GestionmedicaAPI.Repository
{
    public interface Iturnorepository
    {
        Task<List<Turno>> GetTurnoList();
        Task<Turno> GetTurnoforid(int id);
        Task Save();
        Task Add(Turno turno);
        Task Update(Turno turno);
        Task Delete(Turno turno);
        Task Updatepatch (Turno turno);
       
    }
}
