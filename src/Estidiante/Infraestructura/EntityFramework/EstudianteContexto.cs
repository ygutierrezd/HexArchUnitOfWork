using Estidiante.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Estidiante.Infraestructura.EntityFramework
{
    public class EstudianteContexto : DbContext
    {
        public EstudianteContexto(DbContextOptions<EstudianteContexto> options)
            : base(options)
        {
        }

        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<EstudianteMateria> EstudianteMateria { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            
            modelBuilder.Entity<EstudianteMateria>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
        }

    }
}
