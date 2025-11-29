using GestionmedicaAPI.Domain.Entidades;
using GestionmedicaAPI.Dtos.Request;
using GestionmedicaAPI.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionmedicaAPI.Services
{
    public class Pacienteservice : Ipacienteservice
    {
        private readonly Ipacienterepository _repo;
        public Pacienteservice(Ipacienterepository repo)
        {
            _repo = repo;
        }
        public async Task<List<_PacienteGet>> Listar()
        {
            var paciente = await _repo.GetPacientes();

            return paciente.Select(p => new _PacienteGet
            {
                 Nombre = p.Nombre,
                 Apellido = p.Apellido,
                  Numerotelefono = p.Numerotelefono,
                   Id = p.Id,
                    Idpaciente = p.Idpaciente,
                   

            }).ToList();

            
        }
        public async Task<_PacienteGet> Get(int id)
        {
            var paciente = await _repo.Getforid(id);
            if (paciente == null)
                return null;

            return new _PacienteGet
            {
                Apellido = paciente.Apellido,
                Nombre = paciente.Nombre,
                Numerotelefono = paciente.Numerotelefono,
                Idpaciente = paciente.Idpaciente,
                Id = paciente.Id,
            };
        }
         public async Task crear(Pacientecreaterequest dto)
        {
            var paciente = new Paciente
            {
                Apellido = dto.Apellido,
                Nombre = dto.Nombre,    
                Numerotelefono = dto.Numerotelefono,    
                


            };
          await   _repo.Add(paciente);
           await _repo.Save();

        }
        public async Task<bool> Actualizarpaciente(PacientePUTrequest dto,int id)
        {
            var paciente = await _repo.Getforid(id);
            if (paciente == null)
                return false;

            paciente.Numerotelefono = dto.Numerotelefono;
            paciente.Apellido = dto.Apellido;
            paciente.Nombre = dto.Nombre;

          await  _repo.Update(paciente);
            await _repo.Save();
            return true;
        }
        public async Task<bool> Eliminarpaciente(int id)
        {
            var paciente = await _repo.Getforid(id);
            if (paciente == null)
                return false;
            await _repo.delete(paciente);
            await _repo.Save();
            return true;
        }
    }
}
