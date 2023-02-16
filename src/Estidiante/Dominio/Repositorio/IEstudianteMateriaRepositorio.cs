using Estidiante.Dominio.Entidades;

namespace Estidiante.Dominio.Repositorio
{
    public interface IEstudianteMateriaRepositorio
    {
        Task Guardar(EstudianteMateria estudianteMateria);
    }
}
