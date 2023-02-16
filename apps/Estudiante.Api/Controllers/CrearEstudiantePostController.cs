using Estidiante.Aplicacion;
using Estudiante.Api.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace Estudiante.Api.Controllers
{
    [Route("Estudiante")]
    public class CrearEstudiantePostController : ControllerBase
    {
        private readonly GuardarEstudianteMateria _guardarEstudianteMateria;
        public CrearEstudiantePostController(GuardarEstudianteMateria guardarEstudianteMateria) { 
            _guardarEstudianteMateria = guardarEstudianteMateria;
        }

        [HttpPost()]
        public async Task<bool> Index([FromBody] EstudianteMateriaCommand estudiante)
        {
            return await _guardarEstudianteMateria.Handle(estudiante.nombre, estudiante.apellido, estudiante.fechaNacimiento, estudiante.curso, estudiante.materia);
        }
    }
}
