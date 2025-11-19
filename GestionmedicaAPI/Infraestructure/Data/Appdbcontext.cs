using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace GestionmedicaAPI.Infraestructure.Data
{
    using GestionmedicaAPI.Domain.Entidades;
    using Microsoft.EntityFrameworkCore;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Turno> Turnos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           
            modelBuilder.Entity<Paciente>().Property(x => x.Idpaciente).IsRequired();
            modelBuilder.Entity<Turno>().Property(x => x.Id).IsRequired();
        }
    }
}