namespace Estidiante.Dominio.Entidades
{
    public class Estudiante
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string? Curso { get; set; }
    }
}
