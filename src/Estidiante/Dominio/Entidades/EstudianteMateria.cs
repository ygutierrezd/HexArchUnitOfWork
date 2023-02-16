namespace Estidiante.Dominio.Entidades
{
    public class EstudianteMateria
    {
        public Guid Id { get; set; }
        public Guid EstudianteId { get; set; }
        public string? Materia { get; set; }
    }
}
