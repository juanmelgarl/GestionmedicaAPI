using GestionmedicaAPI.Domain.Entidades;
using GestionmedicaAPI.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace GestionmedicaAPI.Repository
{
    public class Pacienterepository : Ipacienterepository
    {
        private readonly AppDbContext _dbContext;

        public Pacienterepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Paciente>> GetPacientes()
        {
            return await _dbContext.Pacientes.ToListAsync();
        }
        public async Task<Paciente> Getforid(int id)
        {
            return await _dbContext.Pacientes.FindAsync(id);
        }
        public async Task Add(Paciente paciente)
        {
             await _dbContext.Pacientes.AddAsync(paciente);
        }
       public async Task Save()
        {
            await _dbContext.SaveChangesAsync();
        }
        public async Task delete(Paciente paciente)
        {
            _dbContext.Pacientes.Remove(paciente);
        }
        public async Task Update(Paciente paciente)
        {
            _dbContext.Pacientes.Update(paciente);
        }
        public async Task Updatepatch(Paciente paciente)
        {
            _dbContext.Pacientes.Update(paciente);
        }
    }
}
