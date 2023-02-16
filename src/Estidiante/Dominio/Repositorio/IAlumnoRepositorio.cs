using Estidiante.Dominio.Entidades;

namespace Estidiante.Dominio.Repositorio
{
    public interface IAlumnoRepositorio
    {
        Task guardar(Estudiante estudiante);
    }
}
