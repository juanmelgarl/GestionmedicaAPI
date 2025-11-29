using GestionmedicaAPI.Domain.Entidades;
using GestionmedicaAPI.Dtos.Response;
using GestionmedicaAPI.Infraestructure.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace GestionmedicaAPI.Repository
{
    public class Turnorepository : Iturnorepository
    {
        private readonly AppDbContext _dbcontext;

        public Turnorepository(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<Turno>> GetTurnoList()
        {
            return  await _dbcontext.Turnos.ToListAsync();
        }
        public async Task<Turno> GetTurnoforid(int id)
        {
            return await _dbcontext.Turnos.FindAsync(id);    
        }
        public async Task  Add(Turno turno)
        {
             await _dbcontext.Turnos.AddAsync(turno);
        }
        public async Task Save()
        {
             await _dbcontext.SaveChangesAsync();
        }
        public async Task Delete(Turno turno)
        {
            _dbcontext.Turnos.Remove(turno);
        }
        public async Task Update(Turno turno)
        {
            _dbcontext.Turnos.Update(turno);
        }
        public async Task Updatepatch(Turno turno)
        {
            _dbcontext.Turnos.Update(turno);
        }
    }
}
