using Estidiante.Dominio.Entidades;
using Estidiante.Dominio.Repositorio;
using Estidiante.Infraestructura.EntityFramework;

namespace Estidiante.Infraestructura.Persistencia
{
    public class MySqlEsudianteRepositorio : IAlumnoRepositorio
    {
        private readonly EstudianteContexto _dbContext;
        public MySqlEsudianteRepositorio(EstudianteContexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task guardar(Estudiante estudiante)
        {
            _dbContext.Estudiante.Add(estudiante);
        }
    }
}
