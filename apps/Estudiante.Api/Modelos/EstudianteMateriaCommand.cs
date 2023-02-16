namespace Estudiante.Api.Modelos
{
    public class EstudianteMateriaCommand
    {
        public string nombre { get; set; }
        public string apellido { get; set; }

        public string curso { get; set; }
        public string materia { get; set; }

        public DateTime fechaNacimiento { get; set; }
    }
}
