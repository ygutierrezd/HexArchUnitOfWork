using Estidiante.Dominio.Entidades;
using Estidiante.Dominio.Repositorio;
using Estidiante.Infraestructura.EntityFramework;

namespace Estidiante.Infraestructura.Persistencia
{
    public class MySqlEstudianteMateriaRepositorio : IEstudianteMateriaRepositorio
    {
        private readonly EstudianteContexto _dbContext;
        public MySqlEstudianteMateriaRepositorio(EstudianteContexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Guardar(EstudianteMateria estudianteMateria)
        {
            _dbContext.EstudianteMateria.Add(estudianteMateria);
        }
    }
}
