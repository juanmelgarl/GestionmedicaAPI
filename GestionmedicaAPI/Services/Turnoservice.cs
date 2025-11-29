using GestionmedicaAPI.Domain.Entidades;
using GestionmedicaAPI.Dtos.Request;
using GestionmedicaAPI.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.JSInterop.Infrastructure;

namespace GestionmedicaAPI.Services
{
    public class Turnoservice : Iturnoservice
    {
        private readonly Iturnorepository _repo;

        public Turnoservice(Iturnorepository repo)
        {
            _repo = repo;
        }

        public async Task<bool> Actualizarturno(TurnoPUTrequest dto, int id)
        {
         var turno = await _repo.GetTurnoforid(id);
            if (turno == null)
            {
                return false;
            }
            turno.Fechaturno = dto.Fechaturno;
            turno.Estadoturno = dto.Estadoturno;
            turno.Especialidad = dto.Especialidad;
            turno.Idpaciente  = dto.Idpaciente;

             await _repo.Update(turno);
            await _repo.Save();
            return true;
        }

        public async Task crear(Turnocreaterequest dto)
        {
            var turno = new Turno
            {
                Especialidad = dto.Especialidad,
                Fechaturno = dto.Fechaturno,


            };
            await _repo.Add(turno);
            await _repo.Save();
        }

        public async Task<bool> Eliminarturno(int id)
        {
            var borrar = await _repo.GetTurnoforid(id);
            if (borrar == null)
            {
                return false;
            }
            await _repo.Delete(borrar);
            await _repo.Save();
            return true;
        }

        public async Task<TurnoGet> Get(int id)
        {
            var obtener = await _repo.GetTurnoforid(id);
            if (obtener == null)
            {
                return null;
            }
            return new TurnoGet
            {
                Id = obtener.Id,
                Especialidad = obtener.Especialidad,
                Estadoturno = obtener.Estadoturno,
                Fechaturno = obtener.Fechaturno,
                Idpaciente = obtener.Idpaciente,
                paciente = obtener.paciente,
            };
            
        }

        public async Task<List<TurnoGet>> Listar()
        {
            var obtener = await _repo.GetTurnoList();
            var list = obtener.Select(t => new TurnoGet
            {
               Id = t.Id,
                Especialidad = t.Especialidad,
                 Estadoturno = t.Estadoturno,
                   Fechaturno = t.Fechaturno,
                    Idpaciente = t.Idpaciente,
                        

            }).ToList();
            return list;

           
        }

     
    }
}
