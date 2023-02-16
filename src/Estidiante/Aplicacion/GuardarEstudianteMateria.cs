using Estidiante.Dominio.Entidades;
using Estidiante.Dominio.Repositorio;
using System.Data;

namespace Estidiante.Aplicacion
{
    public class GuardarEstudianteMateria
    {
        private readonly IAlumnoRepositorio _alumnoRepositorio;
        private readonly IEstudianteMateriaRepositorio _estudianteMateriaRepositorio;
        private readonly IUnitOfWork _unitOfWork;

        public GuardarEstudianteMateria(IAlumnoRepositorio alumnoRepositorio,
            IEstudianteMateriaRepositorio estudianteMateriaRepositorio,
            IUnitOfWork unitOfWork)
        {
            _alumnoRepositorio = alumnoRepositorio;
            _estudianteMateriaRepositorio = estudianteMateriaRepositorio;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(string nombre, string apellido, DateTime fchNacimiento, string curso, string materia)
        {

            using var tran = _unitOfWork.BeginTransaction(IsolationLevel.Serializable);
            try
            {
                var newId = Guid.NewGuid();
                await _alumnoRepositorio.guardar(new Estudiante
                {
                    Apellido = apellido,
                    Curso = curso,
                    FechaNacimiento = fchNacimiento,
                    Id = newId,
                    Nombre = nombre,
                });

                await _unitOfWork.guardar();

                if (string.IsNullOrEmpty(materia))
                    throw new Exception("la materia no puede ser vacia o nula");

                await _estudianteMateriaRepositorio.Guardar(new EstudianteMateria
                {
                    EstudianteId = newId,
                    Id = Guid.NewGuid(),
                    Materia = materia
                });

                await _unitOfWork.guardar();

                tran.Commit();
            }
            catch (Exception) { 
                tran.Rollback();
                return false;
            }

            return true;
        }
    }
}
